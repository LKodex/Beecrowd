# Input
a = IO.gets("") |> String.trim |> String.to_integer
b = IO.gets("") |> String.trim |> String.to_integer

# Processing
result = a + b

# Output
IO.puts("SOMA = #{result}")
