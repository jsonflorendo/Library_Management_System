-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 20, 2025 at 05:58 PM
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
(2, 'FATIMA', 'MONTI', 'GUALVEZ', 'FEMALE', 'Jan-31-2003', '09134567896', 'LOWER', 'b', 'fat', '$2a$12$098z7Qz4kSl6njTUIms3DucWzYMwV6dZQznXz5XbkUDBiiIzno95K', 'STAFF'),
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
  `primary_category_id` int(11) DEFAULT NULL,
  `qty` varchar(10) DEFAULT NULL,
  `primary_author_id` int(11) DEFAULT NULL,
  `primary_publisher_id` int(11) DEFAULT NULL,
  `publish_year` varchar(30) DEFAULT NULL,
  `primary_supplier_id` int(11) DEFAULT NULL,
  `acquisition_date` varchar(30) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_books`
--

INSERT INTO `tbl_books` (`primary_book_id`, `isbn`, `book_name`, `primary_category_id`, `qty`, `primary_author_id`, `primary_publisher_id`, `publish_year`, `primary_supplier_id`, `acquisition_date`, `status`) VALUES
(1, '978-971-07-3964-6', 'EL FILIBUSTERISMO', 1, '11', 1, 3, 'May 08, 2024', 1, 'May 08, 2024', 'Available'),
(2, '9789710639540', 'CINDERELLLA', 1, '19', 2, 3, 'April 16, 2024', 1, 'May 07, 2024', 'Available'),
(5, 'AP091GW', 'LIBRO', 2, '32', 1, 1, 'May 06, 2024', 5, 'May 08, 2024', 'Available');

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
  `category_type` varchar(100) DEFAULT NULL,
  `gender` varchar(100) DEFAULT NULL,
  `borrower_contact_no` varchar(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `borrower_address` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_borrower`
--

INSERT INTO `tbl_borrower` (`primary_borrower_id`, `borrower_id`, `last_name`, `first_name`, `middle_name`, `category_type`, `gender`, `borrower_contact_no`, `email`, `borrower_address`) VALUES
(1, '4221517', 'GUALVEZ', 'FATIMA', 'MONTI', NULL, 'FEMALE', '09123654789', NULL, 'LOWER BICUTAN'),
(2, '1234567', 'BELLO', 'KREYVEN', 'GUALVVEZ', 'STUDENT', 'MALE', '09123654987', 'paul@gmail.com', 'LOWER BICUTAN'),
(3, '100056', 'GALVEZ', 'FATI', 'GOGO', NULL, 'FEMALE', '09231294934', NULL, 'TAGUIG CITY'),
(32, '4221462', 'FLORENDO', 'PAUL ANDREW', 'BARBARA', 'STUDENT', 'MALE', '09092522961', 'paulf5364@gmail.com', 'LOWER BICUTAN'),
(33, '4221507', 'VOSOTROS', 'ALEXANDRA', 'LAURORA', 'STUDENT', 'FEMALE', '09211231135', 'lvardnaxela@gmail.com', 'LOWER BICUTAN');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery`
--

CREATE TABLE `tbl_delivery` (
  `delivery_id` int(10) NOT NULL,
  `book_id` varchar(10) NOT NULL,
  `quantity` varchar(10) DEFAULT NULL,
  `from_location` varchar(100) DEFAULT NULL,
  `to_location` varchar(100) DEFAULT NULL,
  `delivered_by` varchar(100) DEFAULT NULL,
  `delivery_date` varchar(30) NOT NULL,
  `status` varchar(100) DEFAULT NULL,
  `received_by` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_issued_books`
--

CREATE TABLE `tbl_issued_books` (
  `primary_issued_book_id` int(11) NOT NULL,
  `transaction_yyyy_mm` varchar(20) DEFAULT NULL,
  `transaction_series` varchar(10) DEFAULT NULL,
  `primary_borrower_id` int(11) DEFAULT NULL,
  `primary_book_id` int(11) DEFAULT NULL,
  `issued_date` varchar(30) DEFAULT NULL,
  `due_date` varchar(30) DEFAULT NULL,
  `returned_date` varchar(30) NOT NULL,
  `created_at` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_issued_books`
--

INSERT INTO `tbl_issued_books` (`primary_issued_book_id`, `transaction_yyyy_mm`, `transaction_series`, `primary_borrower_id`, `primary_book_id`, `issued_date`, `due_date`, `returned_date`, `created_at`) VALUES
(1, 'BB2025-04', '00001', 3, 5, 'April 01, 2025', 'May 01, 2025', 'April 04, 2025', '2025-04-01'),
(3, 'BB2025-04', '00002', 3, 1, 'April 01, 2025', 'May 01, 2025', '', '2025-04-01'),
(4, 'BB2025-04', '00003', 2, 5, 'April 01, 2025', 'May 01, 2025', 'April 04, 2025', '2025-04-01');

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
(3, 'Late Return', '1,000'),
(4, 'BURN PAGES', '9,874.99'),
(12, 'PENALTY 1', '100'),
(13, 'PENALTY 2', '200'),
(14, 'PENALTY 3', '300');

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
(8, 'JHKHK'),
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
  `primary_borrower_id` int(11) DEFAULT NULL,
  `primary_book_id` int(11) DEFAULT NULL,
  `primary_penalty_description_id` int(11) DEFAULT NULL,
  `penalty_date` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_penalty_report`
--

INSERT INTO `tbl_penalty_report` (`primary_penalty_id`, `primary_borrower_id`, `primary_book_id`, `primary_penalty_description_id`, `penalty_date`) VALUES
(32, 3, 5, 4, 'April 04, 2025'),
(33, 3, 5, 3, 'April 04, 2025'),
(34, 3, 5, 13, 'April 04, 2025'),
(35, 3, 5, 12, 'April 04, 2025'),
(42, 2, 5, 12, 'April 04, 2025'),
(43, 2, 5, 13, 'April 04, 2025'),
(44, 2, 5, 14, 'April 04, 2025');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_shelf`
--

CREATE TABLE `tbl_shelf` (
  `primary_shelf_id` int(11) NOT NULL,
  `shelf_id` varchar(100) DEFAULT NULL,
  `shelf_name` varchar(100) DEFAULT NULL,
  `section` varchar(100) DEFAULT NULL,
  `floor_number` varchar(10) DEFAULT NULL,
  `capacity` varchar(10) DEFAULT NULL,
  `current_load` varchar(10) DEFAULT NULL,
  `created_at` varchar(30) NOT NULL,
  `updated_at` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_shelf`
--

INSERT INTO `tbl_shelf` (`primary_shelf_id`, `shelf_id`, `shelf_name`, `section`, `floor_number`, `capacity`, `current_load`, `created_at`, `updated_at`) VALUES
(3, '123456', 'Shelf Name', 'Section', '1st Floor', '13', '12', 'April 20, 2025', 'April 21, 2025');

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
  ADD PRIMARY KEY (`primary_book_id`),
  ADD KEY `books_library_author_fk_key` (`primary_author_id`),
  ADD KEY `books_library_category_fk_key` (`primary_category_id`),
  ADD KEY `books_library_publisher_fk_key` (`primary_publisher_id`),
  ADD KEY `books_library_supplier_fk_key` (`primary_supplier_id`);

--
-- Indexes for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  ADD PRIMARY KEY (`primary_borrower_id`);

--
-- Indexes for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD PRIMARY KEY (`delivery_id`);

--
-- Indexes for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  ADD PRIMARY KEY (`primary_issued_book_id`),
  ADD KEY `issued_books_books_fk_key` (`primary_book_id`),
  ADD KEY `issued_books_borrower_fk_key` (`primary_borrower_id`);

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
  ADD PRIMARY KEY (`primary_penalty_id`),
  ADD KEY `penalty_report_borrower_fk_key` (`primary_borrower_id`),
  ADD KEY `penalty_report_book_fk_key` (`primary_book_id`),
  ADD KEY `penalty_report_library_penalty_fk_key` (`primary_penalty_description_id`) USING BTREE;

--
-- Indexes for table `tbl_shelf`
--
ALTER TABLE `tbl_shelf`
  ADD PRIMARY KEY (`primary_shelf_id`);

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
  MODIFY `primary_borrower_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `delivery_id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  MODIFY `primary_issued_book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
  MODIFY `primary_penalty_description_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

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
  MODIFY `primary_penalty_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tbl_shelf`
--
ALTER TABLE `tbl_shelf`
  MODIFY `primary_shelf_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_books`
--
ALTER TABLE `tbl_books`
  ADD CONSTRAINT `books_library_author_fk_key` FOREIGN KEY (`primary_author_id`) REFERENCES `tbl_library_author` (`primary_author_id`),
  ADD CONSTRAINT `books_library_category_fk_key` FOREIGN KEY (`primary_category_id`) REFERENCES `tbl_library_category` (`primary_category_id`),
  ADD CONSTRAINT `books_library_publisher_fk_key` FOREIGN KEY (`primary_publisher_id`) REFERENCES `tbl_library_publisher` (`primary_publisher_id`),
  ADD CONSTRAINT `books_library_supplier_fk_key` FOREIGN KEY (`primary_supplier_id`) REFERENCES `tbl_library_supplier` (`primary_supplier_id`);

--
-- Constraints for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  ADD CONSTRAINT `issued_books_books_fk_key` FOREIGN KEY (`primary_book_id`) REFERENCES `tbl_books` (`primary_book_id`),
  ADD CONSTRAINT `issued_books_borrower_fk_key` FOREIGN KEY (`primary_borrower_id`) REFERENCES `tbl_borrower` (`primary_borrower_id`);

--
-- Constraints for table `tbl_penalty_report`
--
ALTER TABLE `tbl_penalty_report`
  ADD CONSTRAINT `penalty_report_book_fk_key` FOREIGN KEY (`primary_book_id`) REFERENCES `tbl_books` (`primary_book_id`),
  ADD CONSTRAINT `penalty_report_borrower_fk_key` FOREIGN KEY (`primary_borrower_id`) REFERENCES `tbl_borrower` (`primary_borrower_id`),
  ADD CONSTRAINT `penalty_report_lib_penalty_fk_key` FOREIGN KEY (`primary_penalty_description_id`) REFERENCES `tbl_library_penalty` (`primary_penalty_description_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
