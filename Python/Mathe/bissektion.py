k1 = 0
k2 = -5
k3 = 0
k4 = 0
k5 = 1
k6 = 0

fw = lambda x: (k1)*x**5 + (k2)*x**4 + (k3)*x**3 + (k4)*x**2 + (k5)*x + k6

#def f2g(x, k1, k2, k3):
#    fw = lambda x: k1*x**2 + k2*x + k3
#    return fw(x)
#def f3g(x, k1, k2, k3, k4):
#    fw = lambda x: k1*x**3 + k2*x**2 + k3*x + k4
#    f = 1
#f1g()x**2 a = -5 , b = 5 
a = 0
b = 2
Delta = 0.000001


def bisektion(f, a, b, Delta):
    if fw(a) * fw(b) > 0:
        print("Es gibt keine Nullstelle oder ein falscher interval wurde gewählt")
        exit(1)
    while b-a > Delta: 
        if fw(a) * fw(((a + b)/ 2)) < 0: 
            b = (a + b) / 2
        if fw(a) * fw((a + b)/ 2) > 0:            
            a = (a + b) / 2
        if b + a == 0:
            return b+a
        if fw(a) * fw(((a + b)/ 2)) == 0:
            return b-a
    return b
x = bisektion(fw, a, b , Delta)
print(f"x = {x}")
print(fw(-2), fw(-1))