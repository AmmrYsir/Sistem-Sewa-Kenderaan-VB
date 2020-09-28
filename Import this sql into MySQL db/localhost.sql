-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Sep 28, 2020 at 04:10 AM
-- Server version: 10.4.14-MariaDB-log
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistem_sewa_kenderaan`
--
CREATE DATABASE IF NOT EXISTS `sistem_sewa_kenderaan` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `sistem_sewa_kenderaan`;

-- --------------------------------------------------------

--
-- Table structure for table `pelajar_table`
--

CREATE TABLE `pelajar_table` (
  `ic_number` varchar(13) NOT NULL,
  `kad_matrik` varchar(35) NOT NULL,
  `jurusan` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelajar_table`
--

INSERT INTO `pelajar_table` (`ic_number`, `kad_matrik`, `jurusan`) VALUES
('000306011651', 'DDWC2018/060559', 'TEKNOLOGI MAKLUMAT');

-- --------------------------------------------------------

--
-- Table structure for table `registration_code`
--

CREATE TABLE `registration_code` (
  `key_id` int(11) NOT NULL,
  `key_user` varchar(12) DEFAULT 'None',
  `key_code` varchar(24) NOT NULL,
  `key_created_date` timestamp NOT NULL DEFAULT current_timestamp(),
  `key_status` varchar(3) NOT NULL DEFAULT 'On',
  `key_usability` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration_code`
--

INSERT INTO `registration_code` (`key_id`, `key_user`, `key_code`, `key_created_date`, `key_status`, `key_usability`) VALUES
(7, '000306011651', 'KYPJ065165YGLQBJB', '2020-09-22 14:15:07', 'On', 0);

-- --------------------------------------------------------

--
-- Table structure for table `rental_car`
--

CREATE TABLE `rental_car` (
  `car_id` int(11) NOT NULL,
  `user_id` varchar(12) NOT NULL,
  `car_title` varchar(75) NOT NULL,
  `car_desc` varchar(255) NOT NULL,
  `car_brand` varchar(12) NOT NULL,
  `car_year` year(4) NOT NULL,
  `car_transmission` varchar(6) NOT NULL,
  `price_per_hour` varchar(2) NOT NULL,
  `car_rating` varchar(3) DEFAULT NULL,
  `car_status` varchar(11) NOT NULL DEFAULT 'Available',
  `car_image` longblob NOT NULL,
  `car_created_date` timestamp NOT NULL DEFAULT current_timestamp(),
  `car_edited_date` date NOT NULL DEFAULT current_timestamp(),
  `rental_time_start` datetime DEFAULT NULL,
  `rental_time_end` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rental_car`
--

INSERT INTO `rental_car` (`car_id`, `user_id`, `car_title`, `car_desc`, `car_brand`, `car_year`, `car_transmission`, `price_per_hour`, `car_rating`, `car_status`, `car_image`, `car_created_date`, `car_edited_date`, `rental_time_start`, `rental_time_end`) VALUES

-- --------------------------------------------------------

--
-- Table structure for table `user_table`
--

CREATE TABLE `user_table` (
  `ic_number` varchar(13) NOT NULL,
  `nama_penuh` varchar(36) NOT NULL,
  `password` varchar(16) NOT NULL,
  `number_phone` varchar(12) NOT NULL,
  `umur` int(2) NOT NULL,
  `alamat_penuh` varchar(100) NOT NULL,
  `email_address` varchar(36) NOT NULL,
  `rank` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_table`
--

INSERT INTO `user_table` (`ic_number`, `nama_penuh`, `password`, `number_phone`, `umur`, `alamat_penuh`, `email_address`, `rank`) VALUES
('000306011651', 'AMMAR YASIR BIN ABD SAMAD', 'Ammar', '01133457990', 20, 'NO74A, KAMPUNG PULAI,\r\n81550 GELANG PATAH,\r\nJOHOR BAHRU, JOHOR.', 'ammaryasir03062000@gmail.com', 2),
('HEP_ADMIN', 'HEPINTERACTIVE', 'admin', '999999999999', 99, 'NONE', 'NONE', 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pelajar_table`
--
ALTER TABLE `pelajar_table`
  ADD KEY `ic_number` (`ic_number`);

--
-- Indexes for table `registration_code`
--
ALTER TABLE `registration_code`
  ADD PRIMARY KEY (`key_id`),
  ADD KEY `registration_code_ibfk_1` (`key_user`);

--
-- Indexes for table `rental_car`
--
ALTER TABLE `rental_car`
  ADD PRIMARY KEY (`car_id`),
  ADD KEY `rental_car_ibfk_1` (`user_id`);

--
-- Indexes for table `user_table`
--
ALTER TABLE `user_table`
  ADD PRIMARY KEY (`ic_number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration_code`
--
ALTER TABLE `registration_code`
  MODIFY `key_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `rental_car`
--
ALTER TABLE `rental_car`
  MODIFY `car_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pelajar_table`
--
ALTER TABLE `pelajar_table`
  ADD CONSTRAINT `pelajar_table_ibfk_1` FOREIGN KEY (`ic_number`) REFERENCES `user_table` (`ic_number`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `registration_code`
--
ALTER TABLE `registration_code`
  ADD CONSTRAINT `registration_code_ibfk_1` FOREIGN KEY (`key_user`) REFERENCES `user_table` (`ic_number`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `rental_car`
--
ALTER TABLE `rental_car`
  ADD CONSTRAINT `rental_car_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_table` (`ic_number`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;