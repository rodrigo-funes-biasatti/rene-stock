-- --------------------------------------------------------
-- Host:                         45.80.152.253
-- Versión del servidor:         5.7.31-0ubuntu0.16.04.1 - (Ubuntu)
-- SO del servidor:              Linux
-- HeidiSQL Versión:             9.5.0.5332
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para BD_DZ
CREATE DATABASE IF NOT EXISTS `BD_DZ` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `BD_DZ`;

-- Volcando estructura para tabla BD_DZ.Condicion_Venta
CREATE TABLE IF NOT EXISTS `Condicion_Venta` (
  `id_condicion_venta` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id_condicion_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla BD_DZ.Contrasenas
CREATE TABLE IF NOT EXISTS `Contrasenas` (
  `id` int(11) NOT NULL,
  `contrasena_actual` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento BD_DZ.datosRecaudacion
DELIMITER //
CREATE DEFINER=`hs`@`%` PROCEDURE `datosRecaudacion`(
	IN `fechaD` DATETIME,
	IN `fechaH` DATETIME



)
SELECT DATE_FORMAT(r.fecha_remito, '%Y-%m-%d'), COUNT(r.codigo_rem) AS 'remitos_generados', COUNT(i.codigo_rem) AS 'prod_vendidos', SUM(r.total_remito) as 'total_remito'
FROM Remitos r JOIN Item_Remito i ON r.codigo_rem = i.codigo_rem
WHERE DATE_FORMAT(r.fecha_remito, '%Y-%m-%d') BETWEEN DATE_FORMAT(fechaD, '%Y-%m-%d') AND DATE_FORMAT(fechaH, '%Y-%m-%d')
GROUP BY DATE_FORMAT(r.fecha_remito, '%Y-%m-%d'), r.codigo_rem//
DELIMITER ;

-- Volcando estructura para procedimiento BD_DZ.datosReportRemito
DELIMITER //
CREATE DEFINER=`hs`@`%` PROCEDURE `datosReportRemito`(
	IN `codigo_rem` INT

)
SELECT i.codigo_rem, cv.descripcion, r.factura_nro, r.fecha_remito, r.cod_barra, r.observaciones, r.total_remito, r.vendedor, i.id_prod, p.marca, p.nombre, i.cantidad, i.precio_unitario, i.subtotal 
FROM Condicion_Venta cv JOIN Remitos r ON cv.id_condicion_venta = r.id_condicion_venta JOIN Item_Remito i ON r.codigo_rem = i.codigo_rem JOIN Productos p ON i.id_prod = p.id_prod
WHERE r.codigo_rem = @codigo_rem//
DELIMITER ;

-- Volcando estructura para tabla BD_DZ.Historial_Contrasenas
CREATE TABLE IF NOT EXISTS `Historial_Contrasenas` (
  `contrasena` varchar(50) NOT NULL,
  `fecha_cambio` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`contrasena`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla BD_DZ.Item_Remito
CREATE TABLE IF NOT EXISTS `Item_Remito` (
  `codigo_rem` bigint(20) NOT NULL,
  `id_prod` int(11) NOT NULL,
  `cantidad` double DEFAULT NULL,
  `precio_unitario` double DEFAULT NULL,
  `subtotal` double DEFAULT NULL,
  PRIMARY KEY (`codigo_rem`,`id_prod`),
  KEY `fk_item_producto` (`id_prod`),
  CONSTRAINT `Item_Remito_ibfk_1` FOREIGN KEY (`codigo_rem`) REFERENCES `Remitos` (`codigo_rem`),
  CONSTRAINT `fk_item_producto` FOREIGN KEY (`id_prod`) REFERENCES `Productos` (`id_prod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento BD_DZ.obtenerItemsRemitoReporte
DELIMITER //
CREATE DEFINER=`hs`@`%` PROCEDURE `obtenerItemsRemitoReporte`(
	IN `cod_rem` INT
)
SELECT i.id_prod, p.marca, p.nombre, i.precio_unitario, i.subtotal
FROM Item_Remito i JOIN Productos p ON i.id_prod = p.id_prod
WHERE codigo_rem = cod_rem//
DELIMITER ;

-- Volcando estructura para procedimiento BD_DZ.obtenerRemitoReporte
DELIMITER //
CREATE DEFINER=`hs`@`%` PROCEDURE `obtenerRemitoReporte`(
	IN `cod_rem` INT



)
SELECT r.codigo_rem, r.fecha_remito, cv.descripcion as 'condicion_venta', r.cod_barra, r.vendedor, r.total_remito, r.observaciones, r.negocio, r.factura_nro
FROM Remitos r JOIN Condicion_Venta cv ON r.id_condicion_venta = cv.id_condicion_venta 
WHERE r.codigo_rem = cod_rem//
DELIMITER ;

-- Volcando estructura para tabla BD_DZ.Productos
CREATE TABLE IF NOT EXISTS `Productos` (
  `id_prod` int(11) NOT NULL,
  `marca` varchar(100) DEFAULT NULL,
  `nombre` varchar(200) DEFAULT '''Pritty''',
  `precio_unitario` double DEFAULT NULL,
  `descripcion` varchar(300) DEFAULT NULL,
  `id_rubro` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_prod`),
  KEY `fk_productos_rubro` (`id_rubro`),
  CONSTRAINT `fk_productos_rubro` FOREIGN KEY (`id_rubro`) REFERENCES `Rubros` (`id_rubro`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla BD_DZ.Remitos
CREATE TABLE IF NOT EXISTS `Remitos` (
  `codigo_rem` bigint(20) NOT NULL,
  `id_condicion_venta` int(11) NOT NULL,
  `factura_nro` bigint(20) DEFAULT NULL,
  `fecha_remito` datetime DEFAULT NULL,
  `cod_barra` bigint(20) DEFAULT NULL,
  `observaciones` varchar(300) DEFAULT NULL,
  `negocio` varchar(150) DEFAULT '-',
  `total_remito` double DEFAULT NULL,
  `vendedor` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo_rem`),
  KEY `fk_remito_condicion` (`id_condicion_venta`),
  CONSTRAINT `fk_remito_condicion` FOREIGN KEY (`id_condicion_venta`) REFERENCES `Condicion_Venta` (`id_condicion_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento BD_DZ.reporteRemitosPrueba
DELIMITER //
CREATE DEFINER=`hs`@`%` PROCEDURE `reporteRemitosPrueba`(
	IN `cod_rem` INT
)
SELECT i.codigo_rem, cv.descripcion, r.factura_nro, r.fecha_remito, r.cod_barra, r.observaciones, r.total_remito, r.vendedor, i.id_prod, p.marca, p.nombre, i.cantidad, i.precio_unitario, i.subtotal 
FROM Condicion_Venta cv JOIN Remitos r ON cv.id_condicion_venta = r.id_condicion_venta JOIN Item_Remito i ON r.codigo_rem = i.codigo_rem JOIN Productos p ON i.id_prod = p.id_prod
WHERE r.codigo_rem = cod_rem//
DELIMITER ;

-- Volcando estructura para tabla BD_DZ.Rubros
CREATE TABLE IF NOT EXISTS `Rubros` (
  `id_rubro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_rubro`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla BD_DZ.Stock
CREATE TABLE IF NOT EXISTS `Stock` (
  `id_prod` int(11) NOT NULL,
  `ult_fecha_modif` datetime DEFAULT CURRENT_TIMESTAMP,
  `cantidad_actual` double DEFAULT '0',
  PRIMARY KEY (`id_prod`),
  CONSTRAINT `fk_stock_producto` FOREIGN KEY (`id_prod`) REFERENCES `Productos` (`id_prod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para disparador BD_DZ.agregar_stock
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `agregar_stock` AFTER INSERT ON `Productos` FOR EACH ROW INSERT INTO Stock SET id_prod = NEW.id_prod//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
