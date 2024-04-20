n=int(input('Введите количество фирм '))
t=0
minimum_stoimost=10000
for i in range (1,n+1):
    x1, y1, z1, x2, y2, z2 = (int(input('Введите для данной фирмы, по порядку, размеры сначала первой упаковки, потом второй ')) for j in range(6))
    c1, c2 = (float(input('Введите для данной фирмы стоимость сначала первой упаковки, потом второй ')) for k in range(2))
    s1=2*(x1*y1+y1*z1+x1*z1) #площадь поверхности 1 упаковки
    s2=2*(x2*y2+y2*z2+x2*z2) #площадь поверхности2 упаковки
    v1=x1*y1*z1 #объём 1 упаковки
    v2=x2*y2*z2 #объём 2 упаковки
    p=(c1-c2*s1/s2)/(v1-v2*s1/s2)*1000 #стоимость молока и упаковки
    if p<minimum_stoimost:
        minimum_stoimost=p
        t=n
minimum_stoimost = round(minimum_stoimost,2)
print('Выгоднее молоко компании № ', t, ',и стоимость равна этого молока равна:', minimum_stoimost)