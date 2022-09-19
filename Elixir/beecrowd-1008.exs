# Input
number = IO.gets("") |> String.trim |> String.to_integer
workedHours = IO.gets("") |> String.trim |> String.to_integer
salaryPerHour = IO.gets("") |> String.trim |> String.to_float

# Processing
salary = workedHours * salaryPerHour |> :erlang.float_to_binary([decimals: 2])

# Output
IO.puts("NUMBER = #{number}")
IO.puts("SALARY = U$ #{salary}")
