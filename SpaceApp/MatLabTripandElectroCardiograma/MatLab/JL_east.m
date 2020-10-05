function [t] = JL_east(h_s,m_s,h_w,m_w,cd_d,ct_d,cd_a,ct_a,dy_d,dy_a)
 % This function creates a schedule for someone who is travelling east. The
 % objective is to help them avoid JetLag.
 % INPUT 
%    h_s:  Hour when you go to sleep  
%    m_s:  Minute when you go to sleep
%    h_w:  Hour when you wake up
%    m_w:  Minute when you wake up 
%    cd_d: City of departure 
%    ct_d: Continent of departure 
%    cd_a: City of arrival
%    ct_a: Continent of arrival 
%    dy_d: Day of departure dd/mm/yyyy
%    dy_a: Day of arrival   dd/mm/yyyy
% OUTPUT
%       t: Schedule 

% Viaje al Este
%% Datos de usuario.
%Hora de dormir
h_sleep = h_s; 
m_sleep = m_s;
%Hora de despertar
h_wake = h_w;
m_wake = m_w;

%Ciudad Partida
cd_departure = cd_d;
ct_departure = ct_d;
%Ciudad Destino
cd_arrival = cd_a; 
ct_arrival = ct_a; 

%Dia de salida 
day_departure = {dy_d};
dy_departure = datetime(day_departure, 'InputFormat', 'dd/MM/uuuu');

%Dia de llegada
day_arrival = {dy_a};
dy_arrival = datetime(day_arrival, 'InputFormat', 'dd/MM/uuuu');

%% Comprobar formato de 24 hrs.
msg = 'Invalid time';
if h_sleep > 24 || h_sleep < 0
    error(msg)
    else if m_sleep > 60 || m_sleep < 0
     error(msg)   
    end
end

if h_sleep > 24 || h_sleep < 0
    error(msg)
    else if m_sleep > 60 || m_sleep < 0
     error(msg)   
    end
end

%% Calculo de Tmin. 
m_sleep = m_sleep/60;
m_wake = m_wake/60;

hrs_sleep = abs((h_sleep + m_sleep) - (h_wake + m_wake)); 

if hrs_sleep > 7
    Tmin = (h_wake + m_wake) - 3; 
    else 
    Tmin = (h_wake + m_wake) - 2;     
end    

%% Zona Horaria
Date_departure = datetime('now','TimeZone','local','Format','Z');
Date_departure.TimeZone = strcat(ct_departure,'/',cd_departure);
TZ_departure = hours(tzoffset(Date_departure));

Date_arrival = datetime('now','TimeZone','local','Format','dd-MM-yyyy HH:mm:ss');
Date_arrival.TimeZone = strcat(ct_arrival,'/',cd_arrival);

TZ_arrival = hours(tzoffset(Date_arrival));

Time_zones = length(TZ_departure:1:TZ_arrival)-1; %Desfase

if Time_zones > 4
    %% Horario
    % Dias antes del viaje (Preparacion para JetLag)
    dy_prepare =  sort(dy_departure - caldays(0:(Time_zones-2)));

    % Dias despues del viaje (Adeaptacion a nueva zona horaria)
    dy_after = sort(dy_arrival + caldays(0:1));

    days=[dy_prepare,dy_after];

    %% Horario para dormir  
    hrs_goSleep = [];
    hrs_goSleep(1) = h_sleep + m_sleep;

    hrs_wakeUp = [];
    hrs_wakeUp(1) = h_wake + m_wake;

    for i = 1:Time_zones 
       hrs_goSleep(i+1) = hrs_goSleep(i) - 1; 
       hrs_wakeUp(i+1) = hrs_wakeUp(i) - 1; 
    end

    for i = 1:Time_zones 
        hrs_goSleep(i+1) = 24 + hrs_goSleep(i+1);
         hrs_wakeUp(i+1) = 24 + hrs_wakeUp(i+1);
    end

    for i = 1:Time_zones
        if hrs_goSleep(i) >= 24
            hrs_goSleep(i) = hrs_goSleep(i) - 24;
        end     
    end    

    for i = 1:Time_zones +1
        if hrs_wakeUp(i) >= 24
            hrs_wakeUp(i) = hrs_wakeUp(i) - 24;
        end 
    end


    hrs_goSleep(Time_zones) = hrs_goSleep(Time_zones) + Time_zones;
    if hrs_goSleep(Time_zones)>= 24
        hrs_goSleep(Time_zones) = hrs_goSleep(Time_zones) -24;
    end    

    hrs_goSleep(Time_zones + 1) = hrs_goSleep(Time_zones + 1) + Time_zones;
    if hrs_goSleep(Time_zones +1)>= 24
        hrs_goSleep(Time_zones + 1) = hrs_goSleep(Time_zones + 1) -24;
    end 

    hrs_wakeUp(Time_zones) = (hrs_wakeUp(Time_zones) + Time_zones);
    if hrs_wakeUp(Time_zones)>= 24
       hrs_wakeUp(Time_zones)= hrs_wakeUp(Time_zones) - 24;
    end

    hrs_wakeUp(Time_zones + 1) = (hrs_wakeUp(Time_zones + 1) + Time_zones);
    if hrs_wakeUp(Time_zones + 1)>= 24
       hrs_wakeUp(Time_zones + 1)= hrs_wakeUp(Time_zones) - 24;
    end

    hrs_gosleep=datestr(hrs_goSleep./24, 'HH:MM');
    hrs_wakeup=datestr(hrs_wakeUp./24,'HH:MM');

 %% Horario Exposicion a la luz
    hrs_preSleep = [];
    for i=1:Time_zones + 1
        hrs_preSleep(i) = hrs_goSleep(i) - .50;
    end
    hrs_presleep = datestr(hrs_preSleep./24,'HH:MM');

    %% Tabla
    dtStr = [cellstr(datestr(days, 'mmmm_dd_yy'))];
    T = -(Time_zones+1-3):2;
    t = table(T',dtStr,hrs_presleep,hrs_gosleep,hrs_wakeup,'VariableNames',{'Day','Date','PreSleep','Sleep','WakeUp'});
    
    else
        fprintf('You are not going to experience JetLag, you need to move 4 Time Zones for that \n')
        t=0;
    end    

end
