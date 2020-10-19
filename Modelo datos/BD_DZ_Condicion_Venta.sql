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


-- Volcando estructura de base de datos para test_rene
CREATE DATABASE IF NOT EXISTS `test_rene` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `test_rene`;

-- Volcando estructura para tabla test_rene.Condicion_Venta
CREATE TABLE IF NOT EXISTS `Condicion_Venta` (
  `id_condicion_venta` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id_condicion_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla test_rene.Condicion_Venta: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `Condicion_Venta` DISABLE KEYS */;
INSERT INTO `Condicion_Venta` (`id_condicion_venta`, `descripcion`) VALUES
	(1, 'Efectivo'),
	(2, 'Cheque'),
	(3, 'Tarjeta Débito'),
	(4, 'Tarjeta Crédito'),
	(5, 'Cuenta Corriente');
/*!40000 ALTER TABLE `Condicion_Venta` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
