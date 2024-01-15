use MyDB;
SELECT * FROM SIGNUP_INFO

CREATE TABLE Leader_Board
(
game_name VARCHAR(100) NOT NULL, 
user_name VARCHAR(255), 
score_value VARCHAR(100)
)

SELECT * FROM SIGNUP_INFO;


SELECT user_name, score_value FROM Leader_Board;

ALTER TABLE Leader_Board
DROP CONSTRAINT PK_Leader_Board;

select max(Convert(int, score_value)) from Leader_Board;
select max(Convert(int, score_value)) from Leader_Board WHERE game_name = 'RunningGame';
SELECT * FROM Leader_Board  where game_name = 'ArcadeGame';

DELETE FROM Leader_Board WHERE game_name='SnakeGame';

SELECT Email FROM SIGNUP_INFO WHERE UserName = 'Admin'