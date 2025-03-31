-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 31, 2025 at 11:55 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_lms`
--
CREATE DATABASE IF NOT EXISTS `db_lms` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_lms`;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `primary_admin_id` int(11) NOT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `gender` varchar(6) DEFAULT NULL,
  `birthday` varchar(30) DEFAULT NULL,
  `contact_no` varchar(11) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `user_type` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`primary_admin_id`, `first_name`, `middle_name`, `last_name`, `gender`, `birthday`, `contact_no`, `address`, `username`, `email`, `password`, `user_type`) VALUES
(1, 'PAUL ANDREW', 'BARBARA', 'FLORENDO', 'MALE', 'Jan-02-2004', '09123456789', 'TAGUIG', 'a', 'paf@gmail.com', 'a', 'ASSISTANT LIBRARIAN'),
(2, 'FATIMA', 'MONTI', 'GUALVEZ', 'FEMALE', 'Jan-31-2003', '09134567896', 'LOWER', 'fati', 'fat', 'fati123', 'STAFF'),
(3, 'ALEXANDRA', 'LAURORA', 'VOSOTROS', 'FEMALE', 'May-05-2024', '09123456789', 'LOWER BICUTAN', 'alex', 'alex@gmail.com', '12345', 'STAFF'),
(5, 'XCVXCV', 'XCVXCV', 'XCVXCV', 'MALE', 'May-05-2024', '345', 'CCVB', 'ae', 'alex', 'xcvxcv', 'ASSISTANT LIBRARIAN'),
(6, 'SDFSD', 'SDFSDF', 'SDF', 'MALE', 'May-05-2024', '43', 'ERTRT', 'ae', 'ae', 'a', 'STAFF');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_books`
--

CREATE TABLE `tbl_books` (
  `primary_book_id` int(11) NOT NULL,
  `isbn` varchar(100) DEFAULT NULL,
  `book_name` varchar(100) DEFAULT NULL,
  `primary_category_id` varchar(11) DEFAULT NULL,
  `qty` varchar(10) DEFAULT NULL,
  `primary_author_id` varchar(11) DEFAULT NULL,
  `primary_publisher_id` varchar(11) DEFAULT NULL,
  `publish_year` varchar(30) DEFAULT NULL,
  `primary_supplier_id` varchar(11) DEFAULT NULL,
  `acquisition_date` varchar(30) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_books`
--

INSERT INTO `tbl_books` (`primary_book_id`, `isbn`, `book_name`, `primary_category_id`, `qty`, `primary_author_id`, `primary_publisher_id`, `publish_year`, `primary_supplier_id`, `acquisition_date`, `status`) VALUES
(1, '978-971-07-3964-6', 'EL FILIBUSTERISMO', '1', '1', '1', '3', 'May 08, 2024', '1', 'May 08, 2024', 'Available'),
(2, '9789710639540', 'CINDERELLLA', '1', '2', '2', '3', 'April 16, 2024', '1', 'May 07, 2024', 'Available'),
(5, 'AP091GW', 'LIBRO', '1', '22', '1', '1', 'May 06, 2024', '5', 'May 08, 2024', 'Available'),
(28, '123', 'SADSAD', '2', '2', '1', '1', 'March 30, 2025', '2', 'March 30, 2025', 'Available'),
(29, 'sadsdf', 'BOOKS', '1', '2', '1', '2', 'March 30, 2025', '1', 'March 30, 2025', 'Available'),
(30, 'sddasdasd', 'ASDASD', '16', '23', '19', '12', 'March 30, 2025', '2', 'March 30, 2025', 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrower`
--

CREATE TABLE `tbl_borrower` (
  `primary_borrower_id` int(11) NOT NULL,
  `borrower_id` varchar(11) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `gender` varchar(100) DEFAULT NULL,
  `borrower_contact_no` varchar(11) DEFAULT NULL,
  `borrower_address` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_borrower`
--

INSERT INTO `tbl_borrower` (`primary_borrower_id`, `borrower_id`, `last_name`, `first_name`, `middle_name`, `gender`, `borrower_contact_no`, `borrower_address`) VALUES
(1, '4221517', 'GUALVEZ', 'FATIMA', 'MONTI', 'FEMALE', '09123654789', 'LOWER BICUTAN'),
(2, '1234567', 'BELLO', 'KREYVEN', 'GUALVVEZ', 'MALE', '09123654987', 'LOWER BICUTAN'),
(3, '100056', 'FATI', 'GALVEZ', 'GOGO', 'FEMALE', '09231294934', 'TAGUIG CITY');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_issued_books`
--

CREATE TABLE `tbl_issued_books` (
  `primary_issued_book_id` int(11) NOT NULL,
  `primary_borrower_id` varchar(11) DEFAULT NULL,
  `primary_book_id` varchar(11) DEFAULT NULL,
  `issued_date` varchar(30) DEFAULT NULL,
  `due_date` varchar(30) DEFAULT NULL,
  `returned_date` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_issued_books`
--

INSERT INTO `tbl_issued_books` (`primary_issued_book_id`, `primary_borrower_id`, `primary_book_id`, `issued_date`, `due_date`, `returned_date`) VALUES
(1, '1', '1', 'Mar-29-2025', 'May-15-2025', ''),
(3, '3', '5', 'Mar-29-2025', 'Apr-28-2025', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_library_author`
--

CREATE TABLE `tbl_library_author` (
  `primary_author_id` int(11) NOT NULL,
  `author_name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_library_author`
--

INSERT INTO `tbl_library_author` (`primary_author_id`, `author_name`) VALUES
(1, 'DR. JOSE P. RIZAL'),
(2, 'WILLIAM SHAKESPEARE'),
(6, 'JOSE'),
(19, 'ASD');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_library_category`
--

CREATE TABLE `tbl_library_category` (
  `primary_category_id` int(11) NOT NULL,
  `category_name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_library_category`
--

INSERT INTO `tbl_library_category` (`primary_category_id`, `category_name`) VALUES
(1, 'ROMANCE'),
(2, 'FANSTASY'),
(16, 'MAMA MO');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_library_penalty`
--

CREATE TABLE `tbl_library_penalty` (
  `primary_penalty_description_id` int(11) NOT NULL,
  `penalty_description` varchar(100) DEFAULT NULL,
  `amount` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_library_penalty`
--

INSERT INTO `tbl_library_penalty` (`primary_penalty_description_id`, `penalty_description`, `amount`) VALUES
(3, 'Late Return', '1000'),
(4, 'BURN PAGES', '100'),
(8, 'DGDFG', '1'),
(9, 'XZCXCV', '1'),
(10, '1234', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_library_publisher`
--

CREATE TABLE `tbl_library_publisher` (
  `primary_publisher_id` int(11) NOT NULL,
  `publisher_name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_library_publisher`
--

INSERT INTO `tbl_library_publisher` (`primary_publisher_id`, `publisher_name`) VALUES
(1, 'Zarah Dela Cruz'),
(2, 'ALEXANDRA'),
(3, 'FATIMA '),
(4, 'FGHFGH'),
(5, 'SDFSDF'),
(7, '7'),
(8, 'JHKHK'),
(11, '123'),
(12, 'SFGF');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_library_supplier`
--

CREATE TABLE `tbl_library_supplier` (
  `primary_supplier_id` int(11) NOT NULL,
  `supplier_id` varchar(11) DEFAULT NULL,
  `supplier_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `email_address` varchar(100) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `source_type` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_library_supplier`
--

INSERT INTO `tbl_library_supplier` (`primary_supplier_id`, `supplier_id`, `supplier_name`, `last_name`, `first_name`, `email_address`, `contact`, `address`, `source_type`) VALUES
(1, 'S0001', 'PAULA-ANDREA', 'FLORENDO', 'PAUL', 'paulf5364@gmail.com', '09092522961', 'LOWER BICUTAN', 'Donator'),
(2, 'S0002', 'SAN', 'VOSOTROS', 'ALEXANDRA', 'alex@gmail.com', '09121312312', 'TAGUIG CITY', 'Supplier'),
(5, 'S0003', 'TAGALIMBAG', 'DELA CRUZ', 'JUAN', 'email@gmail.com', '12345', 'TAGUIG', 'Donator');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penalty_report`
--

CREATE TABLE `tbl_penalty_report` (
  `primary_penalty_id` int(11) NOT NULL,
  `primary_borrower_id` varchar(11) DEFAULT NULL,
  `primary_book_id` varchar(11) DEFAULT NULL,
  `penalty_amount` varchar(10) DEFAULT NULL,
  `primary_penalty_description_id` varchar(11) DEFAULT NULL,
  `penalty_date` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_penalty_report`
--

INSERT INTO `tbl_penalty_report` (`primary_penalty_id`, `primary_borrower_id`, `primary_book_id`, `penalty_amount`, `primary_penalty_description_id`, `penalty_date`) VALUES
(2, '3', '1', '100', '1', 'May-08-2024'),
(3, '3', '1', '132', '1', 'May-09-2024'),
(5, '3', '1', '100', '2', 'May-10-2024');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`primary_admin_id`);

--
-- Indexes for table `tbl_books`
--
ALTER TABLE `tbl_books`
  ADD PRIMARY KEY (`primary_book_id`);

--
-- Indexes for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  ADD PRIMARY KEY (`primary_borrower_id`);

--
-- Indexes for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  ADD PRIMARY KEY (`primary_issued_book_id`);

--
-- Indexes for table `tbl_library_author`
--
ALTER TABLE `tbl_library_author`
  ADD PRIMARY KEY (`primary_author_id`);

--
-- Indexes for table `tbl_library_category`
--
ALTER TABLE `tbl_library_category`
  ADD PRIMARY KEY (`primary_category_id`);

--
-- Indexes for table `tbl_library_penalty`
--
ALTER TABLE `tbl_library_penalty`
  ADD PRIMARY KEY (`primary_penalty_description_id`);

--
-- Indexes for table `tbl_library_publisher`
--
ALTER TABLE `tbl_library_publisher`
  ADD PRIMARY KEY (`primary_publisher_id`);

--
-- Indexes for table `tbl_library_supplier`
--
ALTER TABLE `tbl_library_supplier`
  ADD PRIMARY KEY (`primary_supplier_id`);

--
-- Indexes for table `tbl_penalty_report`
--
ALTER TABLE `tbl_penalty_report`
  ADD PRIMARY KEY (`primary_penalty_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `primary_admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_books`
--
ALTER TABLE `tbl_books`
  MODIFY `primary_book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  MODIFY `primary_borrower_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  MODIFY `primary_issued_book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_library_author`
--
ALTER TABLE `tbl_library_author`
  MODIFY `primary_author_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tbl_library_category`
--
ALTER TABLE `tbl_library_category`
  MODIFY `primary_category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tbl_library_penalty`
--
ALTER TABLE `tbl_library_penalty`
  MODIFY `primary_penalty_description_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_library_publisher`
--
ALTER TABLE `tbl_library_publisher`
  MODIFY `primary_publisher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_library_supplier`
--
ALTER TABLE `tbl_library_supplier`
  MODIFY `primary_supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbl_penalty_report`
--
ALTER TABLE `tbl_penalty_report`
  MODIFY `primary_penalty_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
