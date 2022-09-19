a = IO.gets("") |> String.trim |> String.to_integer
b = IO.gets("") |> String.trim |> String.to_integer

result = a + b

IO.puts("X = #{result}")
