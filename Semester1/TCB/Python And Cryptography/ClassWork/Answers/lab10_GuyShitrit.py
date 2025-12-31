# Assignment: 10
# Author: Guy Shitrit, ID: 330707761

def Q1(nums):
    pass

def Q2(nums):
    def reverseNum(num):
        res = 0

        while num != 0:
            digit = num % 10
            res = res * 10 + digit
            num //= 10

        return res

    res = []

    for num in nums:
        temp = num
        evens = []
        odds = []

        while temp > 0:
            digit = temp % 10
            if digit % 2 == 0:
                evens.append(digit)
            else:
                odds.append(digit)

            temp //= 10

        new_num = 0

        if len(odds) > len(evens):
            for i in range(len(odds)):
                new_num = new_num * 10 + odds[i]

        elif len(evens) > len(odds):
            for i in range(len(evens)):
                new_num = new_num * 10 + evens[i]

        if new_num > 0:
            res.append(reverseNum(new_num))

    return res

def Q3(nums1, nums2):
    counts1 = [0] * 10
    counts2 = [0] * 10

    for num in nums1:
        if num == 0:
            counts1[0] += 1
        while num > 0:
            digit = num % 10
            counts1[digit] += 1
            num //= 10

    for num in nums2:
        if num == 0:
            counts2[0] += 1
        while num > 0:
            digit = num % 10
            counts2[digit] += 1
            num //= 10

    return counts1 == counts2


def Q4(nums):
    def leftDigit(num):
        if 0 <= num <= 9:
            return num

        while num > 9:
            num //= 10

        return num

    res = []

    res = nums.sort(key = lambda x: leftDigit(x))
    
