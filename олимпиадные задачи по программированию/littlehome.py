x, y, l, c1, c2, c3, c4, c5, c6 = (int(input()) for i in range(9)) 
summ = 0
p = 2*(x+y) 
new = c4 + c5 
old = c2 + c3 
snos = c2 + c6 
if (old <= new + snos) and (c1 <= old):
    if (l >= max(x,y)) and (l<p): 
        summ = c1*max(x,y) + (p - l)*new + (l - max(x,y))*old
    if l<max(x,y):
        summ = l*c1 + new*(p-l)
    if l>=p:
        summ = max(x,y)*c1 + (p-max(x,y))*old + (l-p)*snos 
if (old <= new + snos) and (c1 > old):
    if l<p:
        summ = l*old + (p-l)*new
    if l>=p:
        summ = p*old + (l-p)*snos
if (old > new + snos) and (c1<= new + snos):
    if (l >= max(x,y)) and (l<p):
        summ = max(x,y)*c1 + (l-max(x,y))*(new+snos) + (p-l)*new
    if l<max(x,y):
        summ = l*c1 + (p-l)*new
    if l>p:
        summ = max(x,y)*c1 + (p-max(x,y))*(new+snos) + (l-p)*snos
if (old > new + snos) and (c1 > new + snos):
    if l<p:
        summ = l*snos + p*new
    if l>p:
        summ = p*(new + snos) + (l-p)*snos
print(summ)


