a0 = -2
a1 = 0
a2 = 1
a3 = 0 
a4 = 0
a5 = 0
func = lambda x: a0 + a1*x + a2*x**2 + a3*x**3 + a4*x**4 + a5*x**5
func_derivation = lambda x: a1 + 2*a2*x + 3*a3*x**2 + 4*a4*x**3 + 5*a5*x**4
a = 1
b = 2
delta = 10**-5

def newtisches_verfahren(func, func_derivation, a, b , delta):
    xn = (a+b)/2
    d = 1
    if func(a) * func(b) > 0:
        print("Es gibt keine Nullstelle oder ein falscher interval wurde gewählt")
    while d > delta:
        xn1 = xn - (func(xn)/func_derivation(xn))
        d = xn - xn1
        xn = xn1
    return xn

print(newtisches_verfahren(func,func_derivation,a, b, delta))

