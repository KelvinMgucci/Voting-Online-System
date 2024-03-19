-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 19, 2024 at 08:22 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ifmelection_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `candidate`
--

CREATE TABLE `candidate` (
  `ID` int(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `course` varchar(20) NOT NULL,
  `year` varchar(20) NOT NULL,
  `position` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `candidate`
--

INSERT INTO `candidate` (`ID`, `name`, `course`, `year`, `position`) VALUES
(1, 'Halima Hamad', 'BBF', 'Second Year', 'President'),
(2, 'David Shungu', 'BIT', 'First Year', 'President'),
(5, 'Vanessa Fransis', 'BAC', 'Second Year', 'Faculty Representati'),
(6, 'Jamila Mgunda', 'BIT', 'Second Year', 'Faculty Representati'),
(7, 'mess', 'ronaldp', '2', 'president'),
(8, 'jack', 'kigawe', '2', 'president'),
(9, 'johnson', 'wile', '2', 'vice presdent');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `SID` varchar(20) NOT NULL,
  `Sname` varchar(20) NOT NULL,
  `Course` text NOT NULL,
  `Year` text NOT NULL,
  `Status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`SID`, `Sname`, `Course`, `Year`, `Status`) VALUES
('IMC/BCS/2222452', 'Elishama', 'BCS', 'Third Year', 'Voted'),
('IMC/BIT/22222222', 'Mwesi Mwesi', 'BIT', 'Second Year', 'Voted'),
('IMC/BIT/22393880', 'HALOO HELLO', 'BCS', 'First Year', 'Voted'),
('IMC/BIT/227649901', 'HAMAD KIBU', 'BIT', 'Second Year', 'Unvoted'),
('IMC/BSP/2224234', 'JULY', 'BSP', '1', 'Voted');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserID` int(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserID`, `Name`, `UserName`, `password`, `role`) VALUES
(0, 'Admin', 'Mgucci', 'Admin', 'ADMIN');

-- --------------------------------------------------------

--
-- Table structure for table `votes`
--

CREATE TABLE `votes` (
  `CandidateID` int(11) NOT NULL,
  `VoteCount` int(11) NOT NULL,
  `Position` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `votes`
--

INSERT INTO `votes` (`CandidateID`, `VoteCount`, `Position`) VALUES
(1, 7, 'President'),
(2, 3, 'President'),
(5, 6, 'Faculty Representative'),
(6, 4, 'Faculty Representative');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `candidate`
--
ALTER TABLE `candidate`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`SID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `votes`
--
ALTER TABLE `votes`
  ADD PRIMARY KEY (`CandidateID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `candidate`
--
ALTER TABLE `candidate`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
