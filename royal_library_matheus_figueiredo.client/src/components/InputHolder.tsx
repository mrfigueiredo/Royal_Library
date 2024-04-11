import { Input, Text } from "@chakra-ui/react";
import { BookQuery } from "../App";
import { SetStateAction, useState } from "react";

interface Props {
  onSelectISBN: (isbn: string) => void;
  bookQuery: BookQuery;
}

function InputHolder({ onSelectISBN, bookQuery }: Props) {
  const [value, setValue] = useState("");

  const handleChange = (event: {
    target: { value: SetStateAction<string> };
  }) => {
    setValue(event.target.value);
    onSelectISBN(value);
  };

  const handleChange2 = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { value } = e.target;
    setValue(value);
    onSelectISBN(value);
  };

  return (
    <Input
      value={value}
      onChange={handleChange2}
      placeholder="ISBN"
      size="sm"
    />
  );
}
export default InputHolder;
