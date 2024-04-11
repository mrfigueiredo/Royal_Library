import { useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";
import BooksTable from "./components/BooksTable";
import FilterBar from "./components/FilterBar";

export interface BookQuery {
  type: string | null;
  author: string | null;
  isbn: string | null;
  category: string | null;
}

function App() {
  const [bookQuery, setBookQuery] = useState<BookQuery>({} as BookQuery);

  const initialState = {
    bookQuery: {} as BookQuery,
  };

  const reset = () => {
    setBookQuery(initialState.bookQuery);
  };

  return (
    <>
      <FilterBar
        onSelectAuthor={(author) => setBookQuery({ ...bookQuery, author })}
        onSelectType={(type) => setBookQuery({ ...bookQuery, type })}
        onSelectCategory={(category) =>
          setBookQuery({ ...bookQuery, category })
        }
        onSelectISBN={(isbn) => setBookQuery({ ...bookQuery, isbn })}
        onResetFilters={reset}
        bookQuery={bookQuery}
      />
      <BooksTable bookQuery={bookQuery} />
    </>
  );
}

export default App;
