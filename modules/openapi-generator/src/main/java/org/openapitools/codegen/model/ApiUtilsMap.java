package org.openapitools.codegen.model;

import java.util.HashMap;
import java.util.List;

public class ApiUtilsMap extends HashMap<String, Object> {

    public void setOperations(List<OperationsMap> operations) {
        put("utils", operations);
    }

    @SuppressWarnings("unchecked")
    public List<OperationsMap> getOperations() {
        Object operations = get("utils");
        return (List<OperationsMap>) operations;
    }
}
