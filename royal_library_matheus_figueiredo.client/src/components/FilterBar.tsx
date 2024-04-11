import { Box, Button, HStack, Image, Input, Text } from "@chakra-ui/react";
import DropdownFilterSelector from "./DropdownFilterSelector";
import { BookQuery } from "../App";
import InputHolder from "./InputHolder";

interface Props {
  onSelectAuthor: (author: string) => void;
  onSelectType: (type: string) => void;
  onSelectCategory: (category: string) => void;
  onSelectISBN: (isbn: string) => void;
  onResetFilters: () => void;
  bookQuery: BookQuery;
}

const FilterBar = ({
  onSelectAuthor,
  onSelectType,
  onSelectCategory,
  onSelectISBN,
  onResetFilters,
  bookQuery,
}: Props) => {
  return (
    <HStack justifyContent="space-between" padding="25px">
      <DropdownFilterSelector
        key={"authors"}
        text="Authors"
        keyProperty={"author"}
        onSelectProperty={onSelectAuthor}
        selectedProperty={bookQuery.author}
      />
      *{" "}
      <DropdownFilterSelector
        key={"types"}
        text="Types"
        keyProperty={"type"}
        onSelectProperty={onSelectType}
        selectedProperty={bookQuery.type}
      />
      <DropdownFilterSelector
        key={"categories"}
        text="Categories"
        keyProperty={"category"}
        onSelectProperty={onSelectCategory}
        selectedProperty={bookQuery.category}
      />
      <InputHolder onSelectISBN={onSelectISBN} bookQuery={bookQuery} />
      <Button key="Reset" onClick={onResetFilters} color={"red"}>
        Reset
      </Button>
    </HStack>
  );
};

export default FilterBar;
