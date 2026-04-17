INSERT INTO university (univ_id, univ_name, rating, city) VALUES
(1, 'МГУ', 5, 'Москва'),
(2, 'СПбГУ', 4, 'Санкт-Петербург'),
(3, 'КФУ', 4, 'Казань');

INSERT INTO student (student_id, surname, name, stipend, kurs, city, birthday, univ_id) VALUES
(101, 'Иванов', 'Алексей', 2500, 2, 'Москва', '2004-05-12', 1),
(102, 'Петрова', 'Мария', 3000, 3, 'Казань', '2003-11-03', 3),
(103, 'Смирнов', 'Игорь', 2000, 1, 'Санкт-Петербург', '2005-01-20', 2);

INSERT INTO lectures (lecturer_id, surname, name, city, univ_id) VALUES
(1, 'Петров', 'Иван', 'Москва', 1),
(2, 'Сидорова', 'Анна', 'Казань', 3),
(3, 'Иванов', 'Олег', 'Санкт-Петербург', 2);

INSERT INTO subject (subj_id, subj_name, hour, semester) VALUES
(1, 'Математика', 120, 1),
(2, 'Информатика', 100, 1),
(3, 'Физика', 90, 2);

INSERT INTO exam_marks (exam_id, student_id, subj_id, mark, exam_date) VALUES
(1, 101, 1, 5, '2024-06-10'),
(2, 101, 2, 4, '2024-06-15'),
(3, 102, 1, 5, '2024-06-11'),
(4, 103, 3, 3, '2024-06-18');