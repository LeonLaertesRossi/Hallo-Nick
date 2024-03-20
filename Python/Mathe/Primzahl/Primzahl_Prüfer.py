import time
start = time.time()
n = int(input("Geben sie eine zahl an:"))
t = [x for x in range(1, n+1)]
def is_prime(n, t):
    teiler =0
    tt = 0
    if n == 1:
        print("1 ist keine Primzahl")
    elif n == 2:
        print("2 ist eine Primzahl")
    elif n%2 == 0:
        print(f"{n} ist keine Primzahl")
    elif n%2 != 0:
        for x in range(1, n+1):
            Dd = n%t[tt]
            tt += 1
            if Dd == 0:
                teiler +=1
        if teiler > 2:
            print(f"{n} ist keine Primzahl")
        elif teiler == 2:
            print(f"{n} ist eine Primzahl")
end = time.time()
is_prime(n, t)
x = end-start
print(x)
print('{:5.3f}s'.format(end-start))

