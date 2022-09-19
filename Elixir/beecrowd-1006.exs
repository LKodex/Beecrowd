# Input
notaA = IO.gets("") |> String.trim |> String.to_float
notaB = IO.gets("") |> String.trim |> String.to_float
notaC = IO.gets("") |> String.trim |> String.to_float

pesoA = 2
pesoB = 3
pesoC = 5
pesoTotal = pesoA + pesoB + pesoC

# Processing
result = ((notaA * pesoA) + (notaB * pesoB) + (notaC * pesoC)) / pesoTotal |> :erlang.float_to_binary([decimals: 1])

# Output
IO.puts("MEDIA = #{result}")
