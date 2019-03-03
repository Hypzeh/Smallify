import styled from 'styled-components';

const Button = styled.button`
  background-color: #1aa34a;
  border-radius: 500px;
  border-width: 0px;
  padding: 1rem 3rem;
  color: #fff;
  letter-spacing: 2px;
  min-width: 10rem;
  text-transform: uppercase;
  white-space: normal;

  transition-property: background-color, border-color, color, box-shadow, filter;
  transition-duration: 0.3s;

  &:hover {
    background-color: #1db954;
  }
`;

export default Button;