-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 06, 2025 at 10:40 AM
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
(1, 'Paul Andrew', 'Barbara', 'Florendo', 'Male', 'Jan-02-2004', '09123456789', 'Taguig', 'a', 'paul@gmail.com', 'a', 'Assistant Librarian'),
(2, 'Fatima', 'Monti', 'Gualvez', 'Female', 'Jan-31-2003', '09134567896', 'Lower Bicutan, Taguig City', 'b', 'fat', '$2a$12$098z7Qz4kSl6njTUIms3DucWzYMwV6dZQznXz5XbkUDBiiIzno95K', 'Staff'),
(3, 'Alexandra', 'Laurora', 'Vosotros', 'Female', 'May-05-2024', '09123456789', 'Lower Bicutan, Taguig City', 'alex', 'alex@gmail.com', '12345', 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_books`
--

CREATE TABLE `tbl_books` (
  `primary_book_id` int(11) NOT NULL,
  `isbn` varchar(100) DEFAULT NULL,
  `book_name` varchar(100) DEFAULT NULL,
  `primary_category_id` int(11) DEFAULT NULL,
  `primary_author_id` int(11) DEFAULT NULL,
  `primary_publisher_id` int(11) DEFAULT NULL,
  `publish_year` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_books`
--

INSERT INTO `tbl_books` (`primary_book_id`, `isbn`, `book_name`, `primary_category_id`, `primary_author_id`, `primary_publisher_id`, `publish_year`) VALUES
(1, '978-971-07-3964-6', 'Science', 1, 1, 3, 'May 08, 2024'),
(2, '9789710639540', 'Math Scie', 1, 2, 3, 'April 16, 2024'),
(5, 'AP091GW', 'Araling Panlipunan', 2, 1, 1, 'May 06, 2024'),
(32, '23456', 'Sibika at Kultura', 1, 19, 1, 'April 24, 2025'),
(33, '123456', 'Snow White', 2, 1, 1, 'January 15, 2026');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_book_inventory`
--

CREATE TABLE `tbl_book_inventory` (
  `primary_book_inventory_id` int(11) NOT NULL,
  `primary_book_id` int(11) DEFAULT NULL,
  `quantity` int(10) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_book_inventory`
--

INSERT INTO `tbl_book_inventory` (`primary_book_inventory_id`, `primary_book_id`, `quantity`, `status`) VALUES
(1, 33, 39, 'On Stock'),
(2, 32, 50, 'On Stock');

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
(2, '1234567', 'Bello', 'Kreyven', 'Gualvez', 'Student', 'Male', '09123654987', 'paul@gmail.com', 'Lower Bicutan, Taguig City'),
(3, '100056', 'Galvez', 'Fati', 'Gogo', 'Student', 'Female', '09231294934', 'sample@email.com', 'Taguig City'),
(39, '4221462', 'Florendo', 'Paul Andrew', 'Barbara', 'Student', 'Male', '09092522961', 'paulf5364@gmail.com', 'Lower Bicutan, Taguig City'),
(41, '4221256', 'Dela Cruz', 'Zarah', 'Conde', 'Student', 'Female', '09531876545', 'zdelacruzbscs@gmail.com', 'Sta Ana, Taguig City'),
(43, '02-GIA-2024', 'Florendo', 'Jayson', 'Barbara', 'Teacher', 'Male', '1234567890', 'jsonflorendo@gmail.com', 'Taguig City');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery`
--

CREATE TABLE `tbl_delivery` (
  `primary_delivery_id` int(10) NOT NULL,
  `transaction_number` varchar(100) DEFAULT NULL,
  `primary_book_id` int(11) DEFAULT NULL,
  `quantity` varchar(10) DEFAULT NULL,
  `delivered_by` varchar(100) DEFAULT NULL,
  `delivery_date` varchar(30) NOT NULL,
  `received_by` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL
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
  `returned_date` varchar(30) DEFAULT NULL,
  `created_at` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_issued_books`
--

INSERT INTO `tbl_issued_books` (`primary_issued_book_id`, `transaction_yyyy_mm`, `transaction_series`, `primary_borrower_id`, `primary_book_id`, `issued_date`, `due_date`, `returned_date`, `created_at`) VALUES
(1, 'BB2025-05', '00001', 3, 33, 'May 06, 2025', 'May 13, 2025', NULL, '2025-05-06'),
(15, 'BB2025-05', '00002', 3, 32, 'May 06, 2025', 'May 13, 2025', 'May 06, 2025', '2025-05-06');

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
(1, 'Dr. Jose P. Rizal'),
(2, 'William Shakespeares'),
(6, 'Juan Dela Cruz'),
(19, 'Emilio Jacinto');

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
(1, 'Romance'),
(2, 'Fantasy'),
(16, 'Horror'),
(17, 'Science Fiction'),
(18, 'Thriller'),
(19, 'Historical Fiction');

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
(3, 'Late Returned', '1,000'),
(4, 'Burn Pages', '9,874.99'),
(12, 'Penalty 1', '100'),
(13, 'Penalty 2', '200'),
(14, 'Penalty 3', '300'),
(15, 'Penalty 4', '3');

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
(1, 'Bookware Publishing Corporation'),
(2, 'Saint Matthew’s Publishing'),
(3, 'Anvil Publishing'),
(13, 'Ateneo De Manila University Press'),
(15, 'UST Publishing House'),
(16, 'University of The Philippines Press');

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
(1, 'S0001', 'Color Printing Corp', 'Dela Cruz', 'Juan', 'paulf5364@gmail.com', '09092522961', 'Alabang', 'Donator'),
(2, 'S0002', 'Visual Color', 'Santos', 'Ryan', 'alex@gmail.com', '09121312312', 'Manila', 'Supplier'),
(5, 'S0003', 'Tagalimbag', 'Loyzaga', 'Kristine', 'email@gmail.com', '12345', 'Quezon City', 'Donator');

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
(3, '123456', 'FIC-A2', 'Section', '1st Floor', '13', '12', 'April 20, 2025', 'April 21, 2025');

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
  ADD KEY `books_library_publisher_fk_key` (`primary_publisher_id`);

--
-- Indexes for table `tbl_book_inventory`
--
ALTER TABLE `tbl_book_inventory`
  ADD PRIMARY KEY (`primary_book_inventory_id`);

--
-- Indexes for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  ADD PRIMARY KEY (`primary_borrower_id`);

--
-- Indexes for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD PRIMARY KEY (`primary_delivery_id`),
  ADD KEY `delivery_books_fk_key` (`primary_book_id`) USING BTREE;

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
  MODIFY `primary_admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_books`
--
ALTER TABLE `tbl_books`
  MODIFY `primary_book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `tbl_book_inventory`
--
ALTER TABLE `tbl_book_inventory`
  MODIFY `primary_book_inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  MODIFY `primary_borrower_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `primary_delivery_id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_issued_books`
--
ALTER TABLE `tbl_issued_books`
  MODIFY `primary_issued_book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbl_library_author`
--
ALTER TABLE `tbl_library_author`
  MODIFY `primary_author_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `tbl_library_category`
--
ALTER TABLE `tbl_library_category`
  MODIFY `primary_category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tbl_library_penalty`
--
ALTER TABLE `tbl_library_penalty`
  MODIFY `primary_penalty_description_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbl_library_publisher`
--
ALTER TABLE `tbl_library_publisher`
  MODIFY `primary_publisher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tbl_library_supplier`
--
ALTER TABLE `tbl_library_supplier`
  MODIFY `primary_supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_penalty_report`
--
ALTER TABLE `tbl_penalty_report`
  MODIFY `primary_penalty_id` int(11) NOT NULL AUTO_INCREMENT;

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
  ADD CONSTRAINT `books_library_publisher_fk_key` FOREIGN KEY (`primary_publisher_id`) REFERENCES `tbl_library_publisher` (`primary_publisher_id`);

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
