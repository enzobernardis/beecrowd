import array as arr

numbers = arr.array('i', [])

for i in range(4):
    numbers.append(int(input()))

print("DIFERENCA = " + str(numbers[0] * numbers[1] - numbers[2] * numbers[3]))
