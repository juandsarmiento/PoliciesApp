import React, { useState } from 'react';
import { Dropdown, DropdownToggle, DropdownMenu, DropdownItem } from 'reactstrap';

const DropDownClients = ({clients,className,onClick}) => {
  const [dropdownOpen, setDropdownOpen] = useState(false);
  const toggle = () => setDropdownOpen(prevState => !prevState);
  return (
    <Dropdown className={className} isOpen={dropdownOpen} toggle={toggle}>
      <DropdownToggle className='w-100' caret>
        Clients
        </DropdownToggle>
      <DropdownMenu>
        {
            clients.map(c => 
            <DropdownItem key={c.id} onClick={() => onClick(c)}>
              {c.name}
            </DropdownItem>)
        }
      </DropdownMenu>
    </Dropdown>
  );
}
export default DropDownClients;