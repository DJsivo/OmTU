maxn = int(input())
c = maxn
i = 2
while (2 ** i) - 1 <= maxn:
    c += maxn // ((2 ** i) - 1)
    i += 1
print(c)