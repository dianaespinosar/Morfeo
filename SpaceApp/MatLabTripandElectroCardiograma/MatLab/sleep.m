
function sleep(x,y)
initial_phase=zeros(1,17439);
light_sleep=zeros(1,1130);
deep_sleep=zeros(1,10229);
x1=1;
x2=0;
x3=0;
aux=1;
cont=0;
lostpoints=0;
for i=x
    cont=cont+1;
    i;
    if i<=1
        initial_phase(x1)=i;
    else
    n=x(aux);
    j=(i-n);
    if j<=.8410 && j>0.6900 
        x1=x1+1;
        initial_phase(x1)=i;
    elseif j<=0.6910
        x2=x2+1;
        light_sleep(x2)=i;
    elseif j<=1.0610 && j>.8410
        x3=x3+1;
        deep_sleep(x3)=i;
   
    end
    aux=aux+1;
    end
    
end
time=((deep_sleep(end)-deep_sleep(1))/60)/60;
formatSpec = 'Hours in deep sleep %f \n';
fprintf(formatSpec,time)
end
        