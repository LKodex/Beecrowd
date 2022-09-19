# Input
a = IO.gets("") |> String.trim |> String.to_integer
b = IO.gets("") |> String.trim |> String.to_integer
c = IO.gets("") |> String.trim |> String.to_integer
d = IO.gets("") |> String.trim |> String.to_integer

# Processing
result = a * b - c * d

# Output
IO.puts("DIFERENCA = #{result}")
