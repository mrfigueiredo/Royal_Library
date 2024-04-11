export interface IBook {
  id: number;
  title: string;
  type: string;
  author: string;
  total_copies: number;
  copies_in_use: number;
  isbn: string;
  category: string;
}
