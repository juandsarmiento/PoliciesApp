import React from "react";

const Modal = ({
  id = "",
  header,
  footer,
  children,
  isOpen,
  onClose,
  size = "xl",
  style = {},
}) => {
  if (!isOpen) return "";
  return (
    <>
      <div
        className="modal fade show"
        tabIndex="-1"
        role="dialog"
        style={{ display: "block"}}
      >
        <div
          id={id}
          className={`modal-dialog modal-dialog-centered modal-${size}`}
          role="document"
        >
          <div className="modal-content" style={style}>
            <div className="modal-header">
              <h5 className="modal-title">{header}</h5>
              {typeof onClose === "function" && (
                <button type="button" className="close" onClick={onClose}>
                  <span aria-hidden="true">×</span>
                </button>
              )}
            </div>
            <div className="modal-body">{children}</div>
            <div className="modal-footer">{footer}</div>
          </div>
        </div>
      </div>
      <div className="modal-backdrop fade show"></div>
    </>
  );
};
export default Modal;
