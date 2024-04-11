import apiClient from "../services/api-client";
import _ from "lodash";
import { useEffect, useState } from "react";

const useProperty = <T>(key: string) => {
  const [properties, setProperty] = useState<T[]>([]);
  const [error, setError] = useState("");

  useEffect(() => {
    apiClient
      .get("./books")
      .then((response) => {
        const propetyList = response.data;
        const result = _.uniq(_.map(propetyList, (item) => item[key]).sort());
        setProperty(result);
      })
      .catch((error) => setError(error.message));
  }, []);

  return { properties, error };
};

export default useProperty;
