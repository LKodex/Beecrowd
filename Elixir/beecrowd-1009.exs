# Input
name = IO.gets("") |> String.trim
salary = IO.gets("") |> String.trim |> String.to_float
totalSales = IO.gets("") |> String.trim |> String.to_float

comissionRate = 15 / 100 # 15%

# Processing
totalSalary = salary + (totalSales * comissionRate) |> :erlang.float_to_binary([decimals: 2])

# Output
IO.puts("TOTAL = R$ #{totalSalary}")
