aa = 56
bb = 2681 
def gggt(a,b):
    if type(a) != int and type(b) != int:
        exit(1)
    rest = None
    if b > a:
        a, b = b, a
    while rest != 0:
        rest = a % b
        a = b 
        b = rest
    return f"ggt({a})"
    
print(gggt(aa, bb))        