import apiClient from "../services/api-client";
import { useEffect, useState } from "react";

import { IBook } from "../models/IBook";
import _ from "lodash";
import { BookQuery } from "../App";

const useBooks = (bookQuery: BookQuery, deps: any[]) => {
  const [books, setBooks] = useState<IBook[]>([]);
  const [error, setError] = useState("");

  useEffect(() => {
    apiClient
      .get("./books")
      .then((response) => {
        var result = _.filter(response.data, (item) => {
          return _.every(bookQuery, (value, key) => {
            console.log(value);
            console.log(item);
            return _.get(item, key) === value;
          });
        });

        setBooks(result);
      })
      .catch((error) => setError(error.message));
  }, [...deps]);

  return { books, error };
};

export default useBooks;
