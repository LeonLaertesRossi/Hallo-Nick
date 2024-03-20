def isPalindrome(self, n):
        """
        :type x: int
        :rtype: bool
        """
        # die variable n steht für nummer
        pn = n # pn steht für platzhalter nummer. Es wird am ende mit ein bolean wert ausgegeben
        un = [] # um steht für umgekehrte nummer
        if n < 10 and n > -1:
            return f"{pn}: True"
        elif n % 10 == 0:
            return f"{pn}: False"
        else:
            while n > 0:
                rn = n % 10 # rn steht rest nummer
                if n < 10 and n > 0:
                     un.append(n)
                elif n != 10 and rn == 0:
                    un.append(0)
                else:
                     un.append(rn)
                n //= 10
                ldunl = len(un) # ldunl steht für länge der umgekehrte nummer liste
                nindx = []
                if n == 0:
                    for x in range(-1, -((ldunl//2)+1),-1):
                        nindx.append(x)
                    if n == 0 and un[0] == un[-1]:
                        for i, x in enumerate(nindx):
                            if un[i+1] == un[x-1]:
                                w = True
                                if x == nindx[-1] and w == True:
                                    return f"{pn}: True"
                            else:
                                return f"{pn}: False"
                    else:
                        return f"{pn}: False"
                



          

print(isPalindrome(1, 1235635321))