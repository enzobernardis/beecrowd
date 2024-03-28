input1 = input().split()
units1 = int(input1[1])
price1 = float(input1[2])

input2 = input().split()
units2 = int(input2[1])
price2 = float(input2[2])

print("VALOR A PAGAR: R$ %.2f" % (units1 * price1 + units2 * price2))
