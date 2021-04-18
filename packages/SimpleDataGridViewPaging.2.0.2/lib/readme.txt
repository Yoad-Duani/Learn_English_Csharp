There are several custom levels:

1. Read-only mode:
// The first parameter is the database connection,
// the second one is the table name the will be queried and shown in the control.
dataGridViewPaging.DbRequestHandler = DbRequestHandlerHelper.Create(
    new SQLiteConnection("Data Source=chinook.db"),
    "tracks");

2. Editable mode:
// Like the readonly mode but the third parameter is the CommandBuilder object. 
dataGridViewPaging.DbRequestHandler = DbRequestHandlerHelper.Create(
    new SQLiteConnection("Data Source=chinook.db"),
    "tracks",
    new SQLiteCommandBuilder(new SQLiteDataAdapter()));

3. Custom query text:
// The libary will use this statement to query the number of records
// that need to caculate the pagination info.
var countStatementBuilder = new CountStatementBuilder();
countStatementBuilder.CommandText("SELECT COUNT(*) FROM tracks");
// This statement will be used to query the actually data of the table.
// There are 3 placeholders: {0} - table name, {1} - max records, {2} - page offset.
// The libary will pass corresponding data to these placeholders on demand.
var rowsStatementBuilder = new RowsStatementBuilder();
rowsStatementBuilder.CommandText("SELECT * FROM tracks LIMIT {1} OFFSET {2}");
dataGridViewPaging1.DbRequestHandler = new DbRequestHandler
{
    Connection = new SQLiteConnection("Data Source=chinook.db"),
    CountStatementBuilder = countStatementBuilder,
    RowsStatementBuilder = rowsStatementBuilder
};

4. Manual querying: take a look at https://github.com/sontx/simple-datagridview-paging/blob/master/Examples/ManualQueryWithReadOnlyForm.cs