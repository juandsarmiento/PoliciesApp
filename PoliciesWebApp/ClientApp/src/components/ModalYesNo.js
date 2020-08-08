import React from "react";
import Modal from "./Modal";

const ModalYesNo = ({ isOpen, header, children, onClose, onClick }) => (
  <Modal
    isOpen={isOpen}
    header={header}
    onClose={onClose}
    size="sm"
    footer={
      <>
        <button type="button" className="btn btn-secondary" onClick={onClose}>
          No
        </button>
        <button type="button" className="btn btn-primary" onClick={onClick}>
          Yes
        </button>
      </>
    }
  >
    {children}
  </Modal>
);
export default ModalYesNo;
