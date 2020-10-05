close all, clc, clear all
%% initial phase

x=0.01:0.01:2;
      li=30/72;  
      a_pwav=0.25;
      d_pwav=0.09;
      t_pwav=0.16;  
     
      a_qwav=0.025;
      d_qwav=0.066;
      t_qwav=0.166;
      
      a_qrswav=1.6;
      d_qrswav=0.11;
      
      a_swav=0.25;
      d_swav=0.066;
      t_swav=0.09;
      
      a_twav=0.35;
      d_twav=0.142;
      t_twav=0.2;
      
      a_uwav=0.035;
      d_uwav=0.0476;
      t_uwav=0.433;
 pwav=p_wav(x,a_pwav,d_pwav,t_pwav,li);
 %qwav output
 qwav=q_wav(x,a_qwav,d_qwav,t_qwav,li);
 %qrswav output
 qrswav=qrs_wav(x,a_qrswav,d_qrswav,li);
 %swav output
 swav=s_wav(x,a_swav,d_swav,t_swav,li);
 %twav output
 twav=t_wav(x,a_twav,d_twav,t_twav,li);
 %uwav output
 uwav=u_wav(x,a_uwav,d_uwav,t_uwav,li);
 %ecg output
 ecg=pwav+qrswav+twav+swav+qwav+uwav;
 
 
 plot(x,ecg);
 hold on;
 findpeaks(ecg,x,'MinPeakHeight',2);
 [maximosy,maximosx]=findpeaks(ecg,x,'MinPeakHeight',2);
 plot(maximosx,maximosy,'b')
 %% Light sleep
x=1801:0.01:7200;
    li=25/72;  
      a_pwav=0.25;
      d_pwav=0.09;
      t_pwav=0.16;  
     
      a_qwav=0.025;
      d_qwav=0.066;
      t_qwav=0.166;
      
      a_qrswav=1.6;
      d_qrswav=0.11;
      
      a_swav=0.25;
      d_swav=0.066;
      t_swav=0.09;
      
      a_twav=0.35;
      d_twav=0.142;
      t_twav=0.2;
      
      a_uwav=0.035;
      d_uwav=0.0476;
      t_uwav=0.433;
  pwav=p_wav(x,a_pwav,d_pwav,t_pwav,li);
 %qwav output
 qwav=q_wav(x,a_qwav,d_qwav,t_qwav,li);
 %qrswav output
 qrswav=qrs_wav(x,a_qrswav,d_qrswav,li);
 %swav output
 swav=s_wav(x,a_swav,d_swav,t_swav,li);
 %twav output
 twav=t_wav(x,a_twav,d_twav,t_twav,li);
 %uwav output
 uwav=u_wav(x,a_uwav,d_uwav,t_uwav,li);
 %ecg output
 ecg=pwav+qrswav+twav+swav+qwav+uwav;

 
 plot(x,ecg);
 hold on;
 findpeaks(ecg,x,'MinPeakHeight',2.5);
 [maximosy1,maximosx1]=findpeaks(ecg,x,'MinPeakHeight',2.5);
 plot(maximosx1,maximosy1,'b')
 %% deep sleep
 x=7201:0.01:18000;
    li=38/72;  
      a_pwav=0.25;
      d_pwav=0.09;
      t_pwav=0.16;  
     
      a_qwav=0.025;
      d_qwav=0.066;
      t_qwav=0.166;
      
      a_qrswav=1.6;
      d_qrswav=0.11;
      
      a_swav=0.25;
      d_swav=0.066;
      t_swav=0.09;
      
      a_twav=0.35;
      d_twav=0.142;
      t_twav=0.2;
      
      a_uwav=0.035;
      d_uwav=0.0476;
      t_uwav=0.433;
  pwav=p_wav(x,a_pwav,d_pwav,t_pwav,li);
 %qwav output
 qwav=q_wav(x,a_qwav,d_qwav,t_qwav,li);
 %qrswav output
 qrswav=qrs_wav(x,a_qrswav,d_qrswav,li);
 %swav output
 swav=s_wav(x,a_swav,d_swav,t_swav,li);
 %twav output
 twav=t_wav(x,a_twav,d_twav,t_twav,li);
 %uwav output
 uwav=u_wav(x,a_uwav,d_uwav,t_uwav,li);
 %ecg output
 ecg=pwav+qrswav+twav+swav+qwav+uwav;

 
 plot(x,ecg);
 hold on;
 findpeaks(ecg,x,'MinPeakHeight',2);
 [maximosy2,maximosx2]=findpeaks(ecg,x,'MinPeakHeight',2);
 plot(maximosx2,maximosy2,'b')
 %% light sleep(again)
 x=18001:0.01:25200;
      li=30/72;  
      a_pwav=0.25;
      d_pwav=0.09;
      t_pwav=0.16;  
     
      a_qwav=0.025;
      d_qwav=0.066;
      t_qwav=0.166;
      
      a_qrswav=1.6;
      d_qrswav=0.11;
      
      a_swav=0.25;
      d_swav=0.066;
      t_swav=0.09;
      
      a_twav=0.35;
      d_twav=0.142;
      t_twav=0.2;
      
      a_uwav=0.035;
      d_uwav=0.0476;
      t_uwav=0.433;
 pwav=p_wav(x,a_pwav,d_pwav,t_pwav,li);
 %qwav output
 qwav=q_wav(x,a_qwav,d_qwav,t_qwav,li);
 %qrswav output
 qrswav=qrs_wav(x,a_qrswav,d_qrswav,li);
 %swav output
 swav=s_wav(x,a_swav,d_swav,t_swav,li);
 %twav output
 twav=t_wav(x,a_twav,d_twav,t_twav,li);
 %uwav output
 uwav=u_wav(x,a_uwav,d_uwav,t_uwav,li);
 %ecg output
 ecg=pwav+qrswav+twav+swav+qwav+uwav;
 
 
 plot(x,ecg);
 hold on;
 findpeaks(ecg,x,'MinPeakHeight',2);
 [maximosy3,maximosx3]=findpeaks(ecg,x,'MinPeakHeight',2);
 plot(maximosx3,maximosy3,'b')
  ecgmax_x=[maximosx,maximosx1,maximosx2,maximosx3];
  ecgmax_y=[maximosy,maximosy1,maximosy2,maximosy3];
  %% Guardar en archivo .mat
%save('Ecg1','ecgmax_x','ecgmax_y')