
import './App.css';
import { useRef, useState} from 'react';
import ImageUpload from './components/uploadImg';
import DataTable from './components/dataTable';
import { Table } from '@mui/material';
import Data from './services/data-table';
import Service from './services/table';
function App() 
{

  const [showImageUpload, setShowImageUpload] = useState(false);

  const handleButtonClick = () => {
    setShowImageUpload(true);
  };
  const [showDataTable, setShowDataTable] = useState(false);

  const handleButtonClickData = () => {
    setShowDataTable(true);
  };


  return (
    <div>
      <button onClick={handleButtonClick}>להעלאת תמונה</button>
      {showImageUpload && <ImageUpload />}
      <button onClick={handleButtonClickData}>להוספת לקוח </button>
      {showDataTable && <DataTable />}
      <div>
      <h1>Member Data</h1>
      
    </div>  
      <Service/>
    </div>
  );
  


}

export default App;