import React, { useEffect, useState } from 'react';
import axios from 'axios';
import {
  Table,
  TableContainer,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  TextField,
  Button,
} from '@material-ui/core';

const DataTable = () => {
  const [members, setMembers] = useState([]);
  const [newMember, setNewMember] = useState('');

  // Fetch members from the database
  useEffect(() => {
    axios.get('https://localhost:7241/api/Members')
      .then(response => setMembers(response.data))
      .catch(error => console.log(error));
  }, []);

  // Add a new member
  const handleAddMember = () => {
    axios.post('https://localhost:7241/api/Members', { name: newMember })
      .then(response => {
        setMembers(prevMembers => [...prevMembers, response.data]);
        setNewMember('');
      })
      .catch(error => console.log(error));
  };

  return (
    <div>
      <TableContainer>
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>Name</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {members.map(member => (
              <TableRow key={member.id}>
                <TableCell>{member.name}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <TextField
        label="New Member"
        value={newMember}
        onChange={e => setNewMember(e.target.value)}
      />
      <Button variant="contained" color="primary" onClick={handleAddMember}>
        Add Member
      </Button>
    </div>
  );
};

export default DataTable;