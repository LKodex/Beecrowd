# Input
[_, partAQuantity, partAPrice] = IO.gets("") |> String.trim |> String.split
[_, partBQuantity, partBPrice] = IO.gets("") |> String.trim |> String.split

partAQuantity = String.to_integer(partAQuantity)
partBQuantity = String.to_integer(partBQuantity)

partAPrice = String.to_float(partAPrice)
partBPrice = String.to_float(partBPrice)

# Processing
totalCost = (partAQuantity * partAPrice) + (partBQuantity * partBPrice) |> :erlang.float_to_binary([decimals: 2])

# Output
IO.puts("VALOR A PAGAR: R$ #{totalCost}")
