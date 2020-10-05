clear all, close all, clc
fprintf('Schedule Bamgkok-London \n')
t = JL_west(23,0,7,0,'Bangkok','Asia','London','Europe','15/10/2020','15/10/2020');
disp(t)

fprintf('Schedule Kolkata-Tokyo \n')
t2 = JL_west(0,30,8,10,'Tokyo','Asia','Kolkata','Asia','15/10/2020','15/10/2020');
disp(t2)
