CREATE TABLE users(
mail VARCHAR(40) NOT NULL,
full_name VARCHAR(40),
password VARCHAR(40) NOT NULL,
PRIMARY KEY(mail)
);

INSERT INTO [dbo].[users]
([mail]
, [full_name]
, [password]
)
VALUES
('MercedesMan@hotmail.com'
,'Charles Mercedes'
,'NotSofast');

INSERT INTO [dbo].[users]
([mail]
, [full_name]
, [password]
)
VALUES
('YukiThaRookie@AlphaTauri.it'
,'Yuki Tsunoda'
,'ShortmanMeme');

INSERT INTO [dbo].[users]
([mail]
, [full_name]
, [password]
)
VALUES
('AstonMartinDriver@Mercedes.com'
,'Pink Mercedes'
,'Mercedes2019.exe');

SELECT * FROM users;