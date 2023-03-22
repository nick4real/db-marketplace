-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 22, 2023 at 08:34 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `amafundb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `user_login` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`user_login`) VALUES
('roma'),
('stynis');

-- --------------------------------------------------------

--
-- Table structure for table `ads`
--

CREATE TABLE `ads` (
  `id` int(11) NOT NULL,
  `user_login` varchar(30) NOT NULL,
  `category` varchar(20) NOT NULL,
  `title` varchar(100) NOT NULL,
  `description` varchar(5000) NOT NULL,
  `currency` varchar(3) NOT NULL,
  `cost` int(11) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ads`
--

INSERT INTO `ads` (`id`, `user_login`, `category`, `title`, `description`, `currency`, `cost`, `status`) VALUES
(3, 'stynis', 'Всё для детей и мам', 'Delorean 3000', 'Игрушка для вашего мужчины', 'RUB', 8000, 'inactive'),
(4, 'stynis', 'Электроника', 'text', 'text', 'BYN', 7654332, 'inactive'),
(5, 'niko', 'Мужской гардероб', 'Krossovki', 'Nike superheaders 2022', 'USD', 150, 'active'),
(6, 'stynis', 'Электроника', 'Ноутбук HP 15-dbxxx0', 'Очень крутой ноутбук, современный! Высылка почтой', 'BYN', 2300, 'moderate'),
(23, 'david_li', 'Мужской гардероб', 'Пацанские подкрадули', 'В хорошем качестве 9 из 10!!! Кожа натуральная', 'EUR', 30, 'active'),
(24, 'mike_jones', 'Компьютерная техника', 'Asus Tuf Gaming Ultra Max HQ', 'Ноутбук для учебы и работы, стильный и современный есть пару царапинок', 'BYN', 3000, 'active'),
(25, 'jason_ford', 'Авто и транспорт', 'Ford GT', 'Все вопросы по телефону', 'GBP', 60000, 'active'),
(26, 'jessica_wong', 'Услуги', 'Кладка плитки и каминов', 'По вашему чертежу либо дам свои наработки на выбор, цена договорная всё по телефону', 'BYN', 0, 'active'),
(27, 'lisa_baker', 'Бытовая техника', 'Мультиварка Canyon D400', 'Хорошо варит, всё остальное не пробовала да и больше не нужно. Без торга', 'BYN', 300, 'active'),
(28, 'kevin_wu', 'Животные', 'Золотой ретривер мальчик', 'Щенок золотого ретривера, есть все справки и прививки', 'EUR', 200, 'active'),
(29, 'stynis', 'Электроника', 'Телефон Redmi Note 7', 'Рабочий, но весь исцарапан, батарея держит хорошо', 'BYN', 200, 'active'),
(30, 'sarah_smith', 'Сад и огород', 'Инструменты Fiskers', 'Легкие алюминиевые инструменты для сада и огорода, прочные и эффективные. В комплекте грабли, мотычка и лопата', 'EUR', 80, 'active');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_name`) VALUES
('Авто и транспорт'),
('Бизнес оборудование'),
('Бытовая техника'),
('Всё для детей и мам'),
('Все для дома'),
('Женский гардероб'),
('Животные'),
('Компьютерная техника'),
('Красота и здоровье'),
('Мебель'),
('Мужской гардероб'),
('Недвижимость'),
('Ремонт и стройка'),
('Сад и огород'),
('Свадьба и праздники'),
('Спорт и туризм'),
('Телефоны и планшеты'),
('Услуги'),
('Электроника');

-- --------------------------------------------------------

--
-- Table structure for table `conditions`
--

CREATE TABLE `conditions` (
  `status_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `conditions`
--

INSERT INTO `conditions` (`status_name`) VALUES
('active'),
('inactive'),
('moderate');

-- --------------------------------------------------------

--
-- Table structure for table `currencies`
--

CREATE TABLE `currencies` (
  `currency_name` varchar(3) NOT NULL,
  `country` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `currencies`
--

INSERT INTO `currencies` (`currency_name`, `country`) VALUES
('BYN', 'Беларусь'),
('EUR', 'Европа'),
('GBP', 'Англия'),
('RUB', 'Россия'),
('USD', 'США');

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `user_login` varchar(30) NOT NULL,
  `color_theme` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`user_login`, `color_theme`) VALUES
('stynis', 'Random'),
('niko', '#C7DC5B'),
('roma', '#FF5722');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `login` varchar(30) NOT NULL,
  `pass` varchar(30) NOT NULL,
  `name` varchar(30) NOT NULL,
  `phone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`login`, `pass`, `name`, `phone`) VALUES
('david_li', 'c8iKyL7t', 'David Li', '(555) 555-7890'),
('emily_kim', 'b6yTnA4r', 'Emily Kim', '(555) 555-6789'),
('jason_ford', 'k9uHjN2m', 'Jason Ford', '(555) 555-5678'),
('jessica_wong', 'w5uFhR9g', 'Jessica Wong', '(555) 555-8901'),
('john_doe', 'j8yMfHg2', 'John Doe', '(555) 555-1234'),
('kevin_wu', 'n2xTjP8l', 'Kevin Wu', '(555) 555-9012'),
('lauren_lee', 'd4eWfS5a', 'Lauren Lee', '(555) 555-0123'),
('lisa_baker', 'z3xGvB6t', 'Lisa Baker', '(555) 555-4567'),
('mike_jones', 'q4wSdC8h', 'Mike Jones', '(555) 555-3456'),
('niko', '15', 'nikolaj', '12345'),
('roma', 'psun', 'Roma Matveenko', '8(800)5553535'),
('sarah_smith', 'p7tRdE5g', 'Sarah Smith', '(555) 555-2345'),
('stynis', '1', 'maks', '+7788');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD KEY `user_login` (`user_login`);

--
-- Indexes for table `ads`
--
ALTER TABLE `ads`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_login` (`user_login`),
  ADD KEY `category` (`category`),
  ADD KEY `currency` (`currency`),
  ADD KEY `status` (`status`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_name`);

--
-- Indexes for table `conditions`
--
ALTER TABLE `conditions`
  ADD PRIMARY KEY (`status_name`);

--
-- Indexes for table `currencies`
--
ALTER TABLE `currencies`
  ADD PRIMARY KEY (`currency_name`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD KEY `user_login` (`user_login`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`login`),
  ADD UNIQUE KEY `phone` (`phone`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ads`
--
ALTER TABLE `ads`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`user_login`) REFERENCES `users` (`login`) ON DELETE CASCADE;

--
-- Constraints for table `ads`
--
ALTER TABLE `ads`
  ADD CONSTRAINT `ads_ibfk_1` FOREIGN KEY (`user_login`) REFERENCES `users` (`login`) ON DELETE CASCADE,
  ADD CONSTRAINT `ads_ibfk_2` FOREIGN KEY (`category`) REFERENCES `categories` (`category_name`) ON DELETE CASCADE,
  ADD CONSTRAINT `ads_ibfk_3` FOREIGN KEY (`currency`) REFERENCES `currencies` (`currency_name`) ON DELETE CASCADE,
  ADD CONSTRAINT `ads_ibfk_4` FOREIGN KEY (`status`) REFERENCES `conditions` (`status_name`) ON DELETE CASCADE;

--
-- Constraints for table `settings`
--
ALTER TABLE `settings`
  ADD CONSTRAINT `settings_ibfk_1` FOREIGN KEY (`user_login`) REFERENCES `users` (`login`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
