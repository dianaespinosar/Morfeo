clear all, close all, clc
fprintf('Schedule Chicago-Lima \n')
t = JL_east(0,30,8,10,'Chicago','America','Lima','America','03/10/2020','03/10/2020');
disp(t)

fprintf('Schedule Chicago-Paris \n')
t2 = JL_east(0,30,8,10,'Chicago','America','Paris','Europe','03/10/2020','04/10/2020');
disp(t2)

