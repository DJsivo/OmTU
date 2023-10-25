from collections import defaultdict
def f(x):
    if x < 3:
        return 0
    if x == 3:
        return 1
    cash = defaultdict(int)
    if cash[x] == 0:
        cash[x] = f(x // 2) + f(x - x // 2)
        return cash[x]
a=int(input())
print(f(a))