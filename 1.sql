/*
Navicat MySQL Data Transfer

Source Server         : conan
Source Server Version : 50554
Source Host           : localhost:3306
Source Database       : 1

Target Server Type    : MYSQL
Target Server Version : 50554
File Encoding         : 65001

Date: 2017-01-09 10:28:31
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `agentgen_0`
-- ----------------------------
DROP TABLE IF EXISTS `agentgen_0`;
CREATE TABLE `agentgen_0` (
  `Id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of agentgen_0
-- ----------------------------
INSERT INTO `agentgen_0` VALUES ('4', '77');

-- ----------------------------
-- Table structure for `agentgen_1`
-- ----------------------------
DROP TABLE IF EXISTS `agentgen_1`;
CREATE TABLE `agentgen_1` (
  `Id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of agentgen_1
-- ----------------------------
INSERT INTO `agentgen_1` VALUES ('5', '77');
INSERT INTO `agentgen_1` VALUES ('6', '7878');
