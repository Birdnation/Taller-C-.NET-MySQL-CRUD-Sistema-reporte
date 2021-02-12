CREATE DATABASE  IF NOT EXISTS `taller2db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `taller2db`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: taller2db
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `estudiante_paralelo`
--

DROP TABLE IF EXISTS `estudiante_paralelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudiante_paralelo` (
  `Estudianterut` varchar(255) NOT NULL,
  `Paraleloid` varchar(255) NOT NULL,
  `fecha_registro` datetime NOT NULL,
  PRIMARY KEY (`Estudianterut`,`Paraleloid`),
  KEY `FKEstudiante887635` (`Paraleloid`),
  CONSTRAINT `FKEstudiante227576` FOREIGN KEY (`Estudianterut`) REFERENCES `estudiante` (`rut`) ON UPDATE CASCADE,
  CONSTRAINT `FKEstudiante887635` FOREIGN KEY (`Paraleloid`) REFERENCES `paralelo` (`codigo_paralelo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiante_paralelo`
--

LOCK TABLES `estudiante_paralelo` WRITE;
/*!40000 ALTER TABLE `estudiante_paralelo` DISABLE KEYS */;
INSERT INTO `estudiante_paralelo` VALUES ('14.669.878-5','DAII00600C1','2020-08-10 19:14:55'),('17.392.282-5','DAII00600C1','2020-08-10 19:53:56'),('17.392.282-5','DAIS00504C1','2020-08-10 19:53:45'),('17.392.282-5','DAIS00505C1','2020-08-10 19:53:51'),('17.392.282-5','DAIS00518C1','2020-08-10 19:54:02'),('24.998.678-6','DAIS00518C1','2020-08-10 20:01:27'),('25.003.697-5','DAIS00518C1','2020-08-10 20:01:24');
/*!40000 ALTER TABLE `estudiante_paralelo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-10 21:00:42
