def isPalindrome(self, x):
    """
    :type x: int
    :rtype: bool
    """
    x = str(x)
    pl = [y for y in x]
    if pl == pl[::-1]:
        return True
    else: 
        return False  