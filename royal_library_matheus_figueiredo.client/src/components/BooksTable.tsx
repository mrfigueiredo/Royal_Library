import {
  Heading,
  Table,
  TableCaption,
  TableContainer,
  Tbody,
  Td,
  Th,
  Thead,
  Tr,
} from "@chakra-ui/react";
import React from "react";
import { BookQuery } from "../App";
import useBooks from "../hooks/useBooks";

interface Props {
  bookQuery: BookQuery;
}

const BooksTable = ({ bookQuery }: Props) => {
  const { books, error } = useBooks(bookQuery, [bookQuery]);

  return (
    <>
      <TableContainer>
        <Table variant="striped" colorScheme="teal">
          <Thead>
            <Tr>
              <Th>Title</Th>
              <Th>Author</Th>
              <Th>Type</Th>
              <Th>Category</Th>
              <Th>ISBN</Th>
              <Th>Copies</Th>
            </Tr>
          </Thead>
          <Tbody>
            {books.map((book) => (
              <Tr key={book.id}>
                <Td>{book.title}</Td>
                <Td>{book.author}</Td>
                <Td>{book.type}</Td>
                <Td>{book.category}</Td>
                <Td>{book.isbn}</Td>
                <Td>
                  {book.copies_in_use}/{book.total_copies}
                </Td>
              </Tr>
            ))}
          </Tbody>
        </Table>
      </TableContainer>
    </>
  );
};

export default BooksTable;
