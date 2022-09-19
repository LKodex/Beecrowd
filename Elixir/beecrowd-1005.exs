# Input
a = IO.gets("") |> String.trim |> String.to_float
b = IO.gets("") |> String.trim |> String.to_float

pesoA = 3.5
pesoB = 7.5
pesoTotal = 11.0

# Processing
result = ((a * pesoA) + (b * pesoB)) / pesoTotal
result = if result > 10.0, do: 10.0, else: result
result = :erlang.float_to_binary(result, [decimals: 5])

# Output
IO.puts("MEDIA = #{result}")
