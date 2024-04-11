import { BsChevronDown } from "react-icons/bs";
import useProperty from "../hooks/useProperty";
import { Key } from "react";
import {
  Menu,
  MenuButton,
  Button,
  MenuList,
  MenuItem,
  Box,
  color,
} from "@chakra-ui/react";

interface Props<T> {
  keyProperty: string;
  text: string;
  onSelectProperty: (property: T) => void;
  selectedProperty: T | null;
}

const DropdownFilterSelector = <T extends Key | null | undefined>({
  keyProperty,
  selectedProperty,
  text,
  onSelectProperty,
}: Props<T>) => {
  const { properties, error } = useProperty<T>(keyProperty);

  return (
    <Menu>
      <MenuButton as={Button} rightIcon={<BsChevronDown />}>
        {(selectedProperty ? selectedProperty : text) as string}
      </MenuButton>
      <MenuList>
        {properties.map((item) => (
          <MenuItem key={item} onClick={() => onSelectProperty(item)}>
            {item as string}
          </MenuItem>
        ))}
      </MenuList>
    </Menu>
  );
};

export default DropdownFilterSelector;
