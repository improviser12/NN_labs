clc;
clear;
xdel(winsid());

m=100;
n=20;
p=3;
L=m-p;

xfst = 0;

for i=1:m+n
    x(i)=xfst + 0.1 * i;
    y(i)=4*sin(2*x(i))+0.5;
    printf('%f \n', y(i));
end;
//рандомная подборка веса для входящих значений
for i=1:p
    for j=1:p
        w(i, j)=0.2*rand()-0.1;
        printf('w(%d%d) = %f \n', i, j, w(i, j));
    end;
    v(i)=0.2*rand()-0.1;
    printf('v(%d) = %f \n', i, v(i));
end;
//пороги входящих значений
for i=1:p
    T(i) = 0;
    printf('T(%d) = %f \n', i, T(i));
end

T_2=0;
epochs = 1;
Em = 1e-4;
done = %F;
alpha = 0.22;

//тренировка, пока не закончим перебирать все точки либо среднеквадр ошибка будет меньше Em (нашей выбранной)
while done==%F do
    E = 0;
    Es(epochs) = 0;
    for i=1:L
        for j=1:p
            S(j)=0;
            for k=1:p
                S(j)=S(j) + y(i+k-1) * w(k, j)
            end;
            S(j)=S(j)-T(j);
            temp_y(j)=1/(1+%e^(-S(j)));
        end;
        output=0;
        for j=1:p
            output=output+v(j)*temp_y(j);
        end;
        output=output-T_2;
        for j=1:p
            v(j)=v(j) - alpha*(output-y(i+p))*temp_y(j);
        end;
        T_2=T_2+alpha*(output-y(i+p));
        for j=1:p
            for k=1:p
                w(j,k)=w(j,k)-alpha*(output-y(i+p))*v(k)*temp_y(k)*(1-temp_y(k))* y(j+i-1);
            end;
            T(j)=T(j)+alpha*(output-y(i+p))*v(j)*temp_y(j)*(1-temp_y(j));
        end;
        E = E + (output - y(i+p))^2;
    end;
    Es(epochs) = E / 2;
    printf('Es = %f\n', Es(epochs));
    if Es(epochs)<=Em then
        done = %T;
    end;
    if epochs > 1000 //для граф ошибок
        done = %T;
    end;
    epochs = epochs+1;
end;

//обучение нейронной сети
for i=L:L+n
   for j=1:p
       S(j)=0;
       for k=1:p
           S(j)=S(j) + y(i+k-1) * w(k, j)
       end;
       S(j)=S(j)-T(j);
       temp_y(j)=1/(1+%e^(-S(j)));
    end;
    output(i+p)=0;
    for j=1:p
        output(i+p)=output(i+p)+v(j)*temp_y(j);
    end;
    output(i+p)=output(i+p)-T_2;

    printf('%f\n', y(i+p)); //theoretical values
    printf('%f\n', output(i+p)); //testing values
end;

//график ошибки, тренировки и обучения сети
plot(1:length(Es), Es, 'g<-');
xlabel('number of epoch', 'fontsize', 3);
ylabel('Es', 'fontsize', 3);
//halt;
figure();
plot(x(L:L+n), y(L+p:L+p+n), 'b-');
plot(x(L:L+n), output(L+p:L+p+n), 'r->');
