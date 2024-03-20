import math
def sieb(bound):
    if bound < 2:
        return []
    max_ndx = (bound -1) // 2
    sieve = [True] * (max_ndx + 1)

    for ndx in range(int(bound ** 0.5) // 2):
        if sieve[ndx]:
            num = ndx * 2 + 3
            sieve[ndx + num:max_ndx:num] = [False] * ((max_ndx - ndx - num - 1) // num + 1)
    return [2] + [ndx * 2 + 3 for ndx in range(max_ndx) if sieve[ndx]]# 

def primefactordivider(Größerezahl):
    pzr = sieb(Größerezahl)
    x, y = 0,0
    rechenschritt = [[],[],[]] 
    qq = 1
    while x == 0:
        if Größerezahl in pzr:
            rechenschritt = Größerezahl
            break
        while qq == 1 or q.is_integer() == False:
            qq = Größerezahl % pzr[y]
            q = Größerezahl / pzr[y]
            if (q not in pzr) and (q.is_integer() == False):
                y += 1
        rechenschritt[0].append(int(Größerezahl))
        rechenschritt[1].append(pzr[y])
        rechenschritt[2].append(int(q))
        if int(q) in pzr:
            x = 1
        Größerezahl = q
        y = 0
        qq =1
        
    return rechenschritt
Größerezahl = 100001
prim = sieb(Größerezahl)
if Größerezahl not in prim:
    s = primefactordivider(Größerezahl)
    print(sieb(Größerezahl))
    print(s)
    w = 0
    nv = ""
    for x in range(0, len(s[1])):
        if x == 0:
            nv += str(s[1][w])
            w += 1
        elif x != 0:
            nv += "*"+str(s[1][w])
            w += 1
    nv += "*"+str(s[2][-1])
    l = str(Größerezahl)+" = "+nv
    print(l)
else:
    print(Größerezahl)

    
    

