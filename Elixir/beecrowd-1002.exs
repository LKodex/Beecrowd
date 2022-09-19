pi = 3.14159

# Input
radius = IO.gets("") |> String.trim |> String.to_float

# Processing
area = pi * :math.pow(radius, 2.0) |> :erlang.float_to_binary([decimals: 4])

# Output
IO.puts("A=#{area}")
