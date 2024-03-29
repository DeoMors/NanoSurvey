
CREATE TABLE dbo.surveys(
	id int IDENTITY primary key NOT NULL,
	title varchar(100) NOT NULL,
	description varchar(500) NULL
)
GO

CREATE TABLE dbo.question_types(
	id int IDENTITY primary key NOT NULL,
	description varchar(50) NOT NULL
)
GO

CREATE TABLE dbo.questions(
	id int IDENTITY primary key NOT NULL,
	survey_id int foreign key references surveys(id) not null,
	[text] varchar(200) NOT NULL,
	[type] int foreign key references question_types(id) not null
)
GO

CREATE TABLE dbo.answers(
	id int IDENTITY primary key NOT NULL,
	question_id int foreign key references questions(id) not null,
	[text] varchar(200) NOT NULL
)
GO

CREATE TABLE dbo.interviews(
	id int IDENTITY primary key NOT NULL,
	survey_id int foreign key references surveys(id) not null,
	user_id int NULL,
	start_date datetime NULL,
	end_date datetime NULL
)
GO

CREATE TABLE dbo.results(
	id int IDENTITY primary key NOT NULL,
	interview_id int foreign key references interviews(id) NOT NULL,
	answer_id int foreign key references answers(id) NULL
)
GO

ALTER TABLE results
ADD CONSTRAINT UQ_answer_interview_id UNIQUE(answer_id, interview_id);
GO

insert into surveys(title)
values ('Здоровый образ жизни')
GO

insert into question_types(description)
values
('Один вариант ответа'),
('Несколько вариантов ответа')
GO

insert into questions(survey_id, [text], [type])
values 
(1, 'Как много вы курите?', 1),
(1, 'Как часто вы занимаетесь спортом?', 1),
(1, 'Как вы относитесь к фастфуду?', 1),
(1, 'Сколько часов в день вы спите?', 1),
(1, 'Ваше отношение к алкоголю?', 1)
GO

insert into answers(question_id, [text])
values 
(1, 'Не курю'),
(1, 'Меньше одной упаковки в неделю'),
(1, 'Меньше одной упаковки в день'),
(1, 'Пачку в день или больше'),
(2, 'Не занимаюсь спортом'),
(2, '1-2 часа в неделю'),
(2, '3-5 часов в неделю'),
(2, 'Больше 5 часов в неделю'),
(3, 'Не ем фастфуд'),
(3, 'Ем изредка'),
(3, 'Постоянно ем фастфуд'),
(4, '< 3'),
(4, '3-5'),
(4, '5-7'),
(4, '8-9'),
(4, '> 10'),
(5, 'Отрицательно'),
(5, 'Нейстрально'),
(5, 'Положительно')
GO

insert into interviews(survey_id)
values(1)
GO

CREATE INDEX questions_index
ON questions(survey_id)
GO

CREATE INDEX answers_index
ON answers(question_id)
GO

CREATE INDEX results_index
ON results(interview_id)
GO