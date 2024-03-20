def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        index_s1 = 0
        index_s2 = 0
        for x1 in nums:
            ms2 = target - x1
            for x2 in nums:
                if ms2 == x2 and index_s1 != index_s2:
                    s1 = index_s1
                    s2 = index_s2
                    return [s1] + [s2]
                    break#?
                else:
                    if index_s2 == (len(nums)-1):
                        index_s2 = 0
                        break
                index_s2 +=1
            index_s1 += 1

r =twoSum(1,[3,-3, 15], 0)
print(r)