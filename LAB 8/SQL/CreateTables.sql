CREATE TABLE university (
    univ_id bigint PRIMARY KEY,
    univ_name varchar(50),
    rating integer,
    city varchar(50)
);

CREATE TABLE student (
    student_id integer PRIMARY KEY,
    surname varchar(50),
    name varchar(50),
    stipend double precision,
    kurs integer,
    city varchar(50),
    birthday timestamp,
    univ_id integer
);

CREATE TABLE lectures (
    lecturer_id integer PRIMARY KEY,
    surname varchar(50),
    name varchar(50),
    city varchar(50),
    univ_id integer
);

CREATE TABLE subject (
    subj_id integer PRIMARY KEY,
    subj_name varchar(50),
    hour integer,
    semester integer
);

CREATE TABLE exam_marks (
    exam_id integer PRIMARY KEY,
    student_id integer,
    subj_id integer,
    mark integer,
    exam_date timestamp
);

ALTER TABLE student
ADD CONSTRAINT fk_student_university
FOREIGN KEY (univ_id) REFERENCES university(univ_id);

ALTER TABLE lectures
ADD CONSTRAINT fk_lectures_university
FOREIGN KEY (univ_id) REFERENCES university(univ_id);

ALTER TABLE exam_marks
ADD CONSTRAINT fk_exammarks_student
FOREIGN KEY (student_id) REFERENCES student(student_id);

ALTER TABLE exam_marks
ADD CONSTRAINT fk_exammarks_subject
FOREIGN KEY (subj_id) REFERENCES subject(subj_id);